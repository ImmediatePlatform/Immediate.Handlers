using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class BehaviorsAnalyzer : DiagnosticAnalyzer
{
	private static readonly DiagnosticDescriptor BehaviorsMustNotBeRepeated =
		new(
			id: DiagnosticIds.IHR0003BehaviorsMustNotBeRepeated,
			title: "Behaviors must not be repeated",
			messageFormat: "Behavior type '{0}' must be used only once",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Behaviors may not be used more than once in a single pipeline."
		);

	private static readonly DiagnosticDescriptor BehaviorsMustInheritFromBehavior =
		new(
			id: DiagnosticIds.IHR0006BehaviorsMustInheritFromBehavior,
			title: "Behaviors must inherit from Behavior<,>",
			messageFormat: "Behavior type '{0}' must inherit from Behavior<,>",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All Behaviors must inherit from Behavior<,>."
		);

	private static readonly DiagnosticDescriptor BehaviorsMustHaveTwoGenericParameters =
		new(
			id: DiagnosticIds.IHR0007BehaviorsMustHaveTwoGenericParameters,
			title: "Behaviors must have two generic parameters",
			messageFormat: "Behavior type '{0}' must have two generic parameters",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All Behaviors must have two generic parameters, correctly referencing `TRequest` and `TResponse`."
		);

	private static readonly DiagnosticDescriptor BehaviorsMustUseUnboundGenerics =
		new(
			id: DiagnosticIds.IHR0008BehaviorsMustUseUnboundGenerics,
			title: "Behaviors must use unbound generics",
			messageFormat: "Behavior type '{0}' must be a generic type without type arguments",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All behaviors must use a generic type without type arguments."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create<DiagnosticDescriptor>(
		[
			BehaviorsMustNotBeRepeated,
			BehaviorsMustInheritFromBehavior,
			BehaviorsMustHaveTwoGenericParameters,
			BehaviorsMustUseUnboundGenerics,
		]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterOperationAction(AnalyzeOperation, OperationKind.Attribute);
	}

	private void AnalyzeOperation(OperationAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		if (context.Operation is not IAttributeOperation { Operation: IObjectCreationOperation attribute })
			return;

		var behaviorsAttributeSymbol = context.Compilation.GetTypeByMetadataName("Immediate.Handlers.Shared.BehaviorsAttribute");
		if (behaviorsAttributeSymbol is null)
			return;

		token.ThrowIfCancellationRequested();
		if (!SymbolEqualityComparer.Default.Equals(attribute.Type?.OriginalDefinition, behaviorsAttributeSymbol))
			return;

		if (attribute.Arguments.Length != 1)
		{
			// note: this will already be a compiler error anyway
			return;
		}

		token.ThrowIfCancellationRequested();
		var array = attribute.Arguments[0].Value;

		var compilation = context.Compilation;
		var arrayTypeSymbol = compilation.CreateArrayTypeSymbol(compilation.GetTypeByMetadataName("System.Type")!, 1);
		if (!SymbolEqualityComparer.Default.Equals(array.Type, arrayTypeSymbol)
			|| array.ChildOperations.Count != 2
			|| array.ChildOperations.ElementAt(1) is not IArrayInitializerOperation aio)
		{
			// note: this will already be a compiler error anyway
			return;
		}

		token.ThrowIfCancellationRequested();
		var baseBehaviorSymbol = context.Compilation.GetTypeByMetadataName("Immediate.Handlers.Shared.Behavior`2");
		if (baseBehaviorSymbol is null)
			return;

		var seenBehaviors = new HashSet<string>();
		foreach (var op in aio.ChildOperations)
		{
			token.ThrowIfCancellationRequested();
			if (op is not ITypeOfOperation
				{
					TypeOperand: INamedTypeSymbol behaviorType,
					Syntax: TypeOfExpressionSyntax toes,
				}
			)
			{
				continue;
			}

			var location = toes.Type.GetLocation();
			var originalDefinition = behaviorType.OriginalDefinition;

			if (!ImplementsBaseClass(originalDefinition, baseBehaviorSymbol))
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustInheritFromBehavior,
						location,
						originalDefinition.Name)
				);
			}

			if (!originalDefinition.IsGenericType
				|| originalDefinition.TypeParameters.Length != 2)
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustHaveTwoGenericParameters,
						location,
						originalDefinition.Name)
				);
			}
			else if (!behaviorType.IsUnboundGenericType)
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustUseUnboundGenerics,
						location,
						originalDefinition.Name)
				);
			}

			if (!seenBehaviors.Add(originalDefinition.ToString()))
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustNotBeRepeated,
						location,
						originalDefinition.Name)
				);
			}
		}
	}

	private static bool ImplementsBaseClass(INamedTypeSymbol typeSymbol, INamedTypeSymbol typeToCheck) =>
		SymbolEqualityComparer.Default.Equals(typeSymbol, typeToCheck)
		|| (typeSymbol.BaseType is not null
			&& ImplementsBaseClass(typeSymbol.BaseType.OriginalDefinition, typeToCheck)
		);
}
