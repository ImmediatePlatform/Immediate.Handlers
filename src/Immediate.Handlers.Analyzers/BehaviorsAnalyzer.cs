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

	public static readonly DiagnosticDescriptor BehaviorHasIncorrectTypeArgument =
		new(
			id: DiagnosticIds.IHR0020BehaviorHasIncorrectTypeArgument,
			title: "Behavior has incorrect type argument",
			messageFormat: "Behavior type '{0}' has type arguments that don't match the handler's request or response types",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Behavior type arguments must be compatible with the handler's request and response types."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			BehaviorsMustInheritFromBehavior,
			BehaviorsMustHaveTwoGenericParameters,
			BehaviorsMustUseUnboundGenerics,
			BehaviorHasIncorrectTypeArgument,
		]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterOperationAction(AnalyzeOperation, OperationKind.Attribute);
		context.RegisterSymbolAction(AnalyzeHandlerBehaviors, SymbolKind.NamedType);
	}

	private void AnalyzeOperation(OperationAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		if (context.Operation is not IAttributeOperation { Operation: IObjectCreationOperation attribute })
			return;

		if (attribute is not { Type.IsBehaviorsAttribute: true, Arguments: [{ } array] })
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
		var baseBehaviorSymbol = context.Compilation.GetTypeByMetadataName("Immediate.Handlers.Shared.Behavior`2");
		if (baseBehaviorSymbol is null)
			return;

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
			if (originalDefinition.IsGenericType
				&& originalDefinition.TypeParameters.Length > 2)
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorsMustHaveTwoGenericParameters,
						location,
						originalDefinition.Name)
				);
			}
			else if (originalDefinition.IsGenericType && !behaviorType.IsUnboundGenericType)
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

	private void AnalyzeHandlerBehaviors(SymbolAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		var typeSymbol = (INamedTypeSymbol)context.Symbol;

		// Check if this type has a [Handler] attribute
		var hasHandlerAttribute = typeSymbol.GetAttributes()
			.Any(a => a is { AttributeClass.IsHandlerAttribute: true });

		if (!hasHandlerAttribute)
			return;

		// Check for [Behaviors] attribute on the type
		var behaviorsAttribute = typeSymbol.GetAttributes()
			.FirstOrDefault(a => a is { AttributeClass.IsBehaviorsAttribute: true });

		if (behaviorsAttribute is null || behaviorsAttribute.ConstructorArguments.Length != 1)
			return;

		token.ThrowIfCancellationRequested();

		// Get the behaviors array
		var behaviorsArray = behaviorsAttribute.ConstructorArguments[0];
		if (behaviorsArray.Kind != TypedConstantKind.Array)
			return;

		// Find the HandleAsync method to get request/response types
		var handleMethod = typeSymbol.GetMembers("HandleAsync")
			.OfType<IMethodSymbol>()
			.FirstOrDefault(m => m.Parameters.Length >= 1);

		if (handleMethod is null)
			return;

		// Get handler request and response types
		var requestType = handleMethod.Parameters[0].Type;
		var responseType = handleMethod.ReturnType is INamedTypeSymbol { Arity: 1 } namedReturnType
			? namedReturnType.TypeArguments[0]
			: null;

		if (requestType is null || responseType is null)
			return;

		token.ThrowIfCancellationRequested();

		// Validate each behavior
		foreach (var behaviorConstant in behaviorsArray.Values)
		{
			if (behaviorConstant.Value is not INamedTypeSymbol behaviorType)
				continue;

			token.ThrowIfCancellationRequested();

			var originalDefinition = behaviorType.OriginalDefinition;
			if (!originalDefinition.ImplementsBehavior())
				continue;

			// Find the Behavior<TRequest, TResponse> base type
			var behaviorBaseType = FindBehaviorBaseType(originalDefinition);
			if (behaviorBaseType is null || behaviorBaseType.TypeArguments.Length != 2)
				continue;

			var behaviorRequestType = behaviorBaseType.TypeArguments[0];
			var behaviorResponseType = behaviorBaseType.TypeArguments[1];

			// Check if behavior has fixed types that don't match handler types
			var typeParamCount = originalDefinition.TypeParameters.Length;

			if (typeParamCount == 0)
			{
				// Non-generic behavior - both types must match exactly
				if (!SymbolEqualityComparer.Default.Equals(behaviorRequestType, requestType) ||
					!SymbolEqualityComparer.Default.Equals(behaviorResponseType, responseType))
				{
					ReportBehaviorTypeArgumentMismatch(context, behaviorsAttribute, originalDefinition.Name);
				}
			}
			else if (typeParamCount == 1)
			{
				// Single parameter behavior - check which position has the fixed type
				var typeParam = originalDefinition.TypeParameters[0];

				if (behaviorRequestType is ITypeParameterSymbol reqParam &&
					SymbolEqualityComparer.Default.Equals(reqParam.OriginalDefinition, typeParam))
				{
					// Request is parameterized, response is fixed
					if (!SymbolEqualityComparer.Default.Equals(behaviorResponseType, responseType))
					{
						ReportBehaviorTypeArgumentMismatch(context, behaviorsAttribute, originalDefinition.Name);
					}
				}
				else if (behaviorResponseType is ITypeParameterSymbol respParam &&
						 SymbolEqualityComparer.Default.Equals(respParam.OriginalDefinition, typeParam))
				{
					// Response is parameterized, request is fixed
					if (!SymbolEqualityComparer.Default.Equals(behaviorRequestType, requestType))
					{
						ReportBehaviorTypeArgumentMismatch(context, behaviorsAttribute, originalDefinition.Name);
					}
				}
			}
			// For typeParamCount == 2, both are parameterized, so no fixed type to check
		}
	}

	private static INamedTypeSymbol? FindBehaviorBaseType(INamedTypeSymbol symbol)
	{
		var current = symbol.BaseType;
		while (current is not null)
		{
			if (current.IsBehavior2)
				return current;
			current = current.BaseType;
		}

		return null;
	}

	private static void ReportBehaviorTypeArgumentMismatch(SymbolAnalysisContext context, AttributeData attribute, string behaviorName)
	{
		var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken).GetLocation()
			?? Location.None;

		context.ReportDiagnostic(
			Diagnostic.Create(
				BehaviorHasIncorrectTypeArgument,
				location,
				behaviorName)
		);
	}
}

