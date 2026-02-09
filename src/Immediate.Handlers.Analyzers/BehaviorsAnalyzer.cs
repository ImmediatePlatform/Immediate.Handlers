using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class BehaviorsAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor BehaviorsMustInheritFromBehavior =
		new(
			id: DiagnosticIds.IHR0006BehaviorsMustInheritFromBehavior,
			title: "Behaviors must inherit from Behavior<,>",
			messageFormat: "Behavior type '{0}' must inherit from Behavior<,>",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All Behaviors must inherit from Behavior<,>."
		);

	public static readonly DiagnosticDescriptor BehaviorsMustHaveTwoGenericParameters =
		new(
			id: DiagnosticIds.IHR0007BehaviorsMustHaveTwoGenericParameters,
			title: "Behaviors must not have more than two generic parameters",
			messageFormat: "Behavior type '{0}' must have zero, one, or two generic parameters",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All Behaviors must have zero, one, or two generic parameters."
		);

	public static readonly DiagnosticDescriptor BehaviorsMustUseUnboundGenerics =
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
		ImmutableArray.Create(
		[
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

		if (attribute is not { Type.IsBehaviorsAttribute: true, Arguments: [{ Value: { } array }] })
			return;

		token.ThrowIfCancellationRequested();

		if (array is not
			{
				Type: IArrayTypeSymbol
				{
					ElementType:
					{
						Name: "Type",
						ContainingNamespace:
						{
							Name: "System",
							ContainingNamespace.IsGlobalNamespace: true,
						},
					},
				},
				ChildOperations.Count: 2
			}
			|| array.ChildOperations.ElementAt(1) is not IArrayInitializerOperation aio)
		{
			// note: this will already be a compiler error anyway
			return;
		}

		token.ThrowIfCancellationRequested();

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

			if (!originalDefinition.ImplementsBehavior())
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustInheritFromBehavior,
						location,
						originalDefinition.Name)
				);
			}

			// Allow 0, 1, or 2 generic parameters. Warn on 3+
			if (!originalDefinition.IsGenericType)
				continue;

			if (originalDefinition.TypeParameters.Length > 2)
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustHaveTwoGenericParameters,
						location,
						originalDefinition.Name)
				);
			}

			if (!behaviorType.IsUnboundGenericType)
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustUseUnboundGenerics,
						location,
						originalDefinition.Name)
				);
			}
		}
	}
}
