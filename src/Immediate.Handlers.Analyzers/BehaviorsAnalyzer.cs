using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class BehaviorsAnalyzer : DiagnosticAnalyzer
{
	private static readonly DiagnosticDescriptor BehaviorsMustInheritFromBehavior =
		new(
			id: DiagnosticIds.IHR0006BehaviorsMustInheritFromBehavior,
			title: "Behaviors must inherit from Behavior<,>",
			messageFormat: "Behavior '{0}' must inherit from Behavior<,>",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All Behaviors must inherit from Behavior<,> in order to be used properly."
		);

	private static readonly DiagnosticDescriptor BehaviorsMustHaveTwoGenericParameters =
		new(
			id: DiagnosticIds.IHR0007BehaviorsMustHaveTwoGenericParameters,
			title: "Behaviors must have two generic parameters",
			messageFormat: "Behavior '{0}' must have two generic parameters",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All Behaviors must have two generic parameters in order to be used properly."
		);

	private static readonly DiagnosticDescriptor BehaviorsMustNotInheritFromBoundedBehaviour =
		new(
			id: DiagnosticIds.IHR0008BehaviorsMustNotInheritFromBoundedBehaviour,
			title: "Behaviors must not inherit from bounded Behaviour",
			messageFormat: "Behavior '{0}' must not inherit from bounded Behaviour",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All Behaviors must not inherit from bounded Behaviour in order to be used properly."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create<DiagnosticDescriptor>(
		[
			BehaviorsMustInheritFromBehavior,
			BehaviorsMustHaveTwoGenericParameters,
			BehaviorsMustNotInheritFromBoundedBehaviour
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
		var baseBehaviorSymbol = context.Compilation.GetTypeByMetadataName("Immediate.Handlers.Shared.Behavior`2");

		if (baseBehaviorSymbol is null)
		{
			return;
		}

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
		if (array is null
			|| !SymbolEqualityComparer.Default.Equals(array.Type, arrayTypeSymbol)
			|| array.ChildOperations.Count != 2
			|| array.ChildOperations.ElementAt(1) is not IArrayInitializerOperation aio)
		{
			// note: this will already be a compiler error anyway
			return;
		}

		foreach (var op in aio.ChildOperations)
		{
			token.ThrowIfCancellationRequested();
			if (op is not ITypeOfOperation { TypeOperand: INamedTypeSymbol behaviorType, })
				continue;

			var originalDefinition = behaviorType.OriginalDefinition;

			// originalDefinition.IsAbstract
			if (!ImplementsBaseClass(originalDefinition, baseBehaviorSymbol))
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustInheritFromBehavior,
						op.Syntax.GetLocation(),
						originalDefinition.Name)
				);

				continue;
			}

			if (!originalDefinition.IsGenericType)
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustNotInheritFromBoundedBehaviour,
						op.Syntax.GetLocation(),
						originalDefinition.Name)
				);

				continue;
			}

			// HasReferencesToTypeWithoutTwoGenericParameters
			if (!behaviorType.IsUnboundGenericType
				|| (behaviorType.IsUnboundGenericType && originalDefinition.TypeParameters.Length != 2))
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustHaveTwoGenericParameters,
						op.Syntax.GetLocation(),
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
