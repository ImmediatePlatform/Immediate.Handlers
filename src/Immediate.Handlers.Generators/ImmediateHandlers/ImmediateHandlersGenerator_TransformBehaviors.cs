using Immediate.Handlers.Shared;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators.ImmediateHandlers;

public partial class ImmediateHandlersGenerator
{
	private static EquatableReadOnlyList<Behavior?> TransformBehaviors(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var semanticModel = context.SemanticModel;
		var compilation = semanticModel.Compilation;
		cancellationToken.ThrowIfCancellationRequested();

		return ParseBehaviors(context.Attributes[0], compilation, cancellationToken);
	}

	private static EquatableReadOnlyList<Behavior?> ParseBehaviors(
		AttributeData attribute,
		Compilation compilation,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();
		var behaviorType = typeof(Behavior<,>);
		var behaviorTypeSymbol = compilation.GetTypeByMetadataName(behaviorType.FullName!);
		if (behaviorTypeSymbol is null)
			return [];

		if (attribute.ConstructorArguments.Length != 1)
			return [];

		var ca = attribute.ConstructorArguments[0];
		var arrayTypeSymbol = compilation.CreateArrayTypeSymbol(compilation.GetTypeByMetadataName("System.Type")!, 1);
		if (!SymbolEqualityComparer.Default.Equals(ca.Type, arrayTypeSymbol))
			return [];

		cancellationToken.ThrowIfCancellationRequested();
		return ca.Values
			.Select(v =>
			{
				cancellationToken.ThrowIfCancellationRequested();
				if (v.Value is not INamedTypeSymbol symbol)
					return null;

				if (!symbol.IsUnboundGenericType)
					return null;

				var originalDefinition = symbol.OriginalDefinition;
				if (originalDefinition.TypeParameters.Length != 2)
					return null;

				if (originalDefinition.IsAbstract)
					return null;

				if (!originalDefinition.ImplementsBaseClass(behaviorTypeSymbol))
					return null;

				cancellationToken.ThrowIfCancellationRequested();

				// global::Dummy.LoggingBehavior<,>
				// for: `services.AddScoped(typeof(..));`
				var typeName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

				cancellationToken.ThrowIfCancellationRequested();

				// global::Dummy.LoggingBehavior
				// for: private readonly global::Dummy.LoggingBehavior
				var constructorType = symbol.OriginalDefinition.ToDisplayString(DisplayNameFormatters.NonGenericFqdnFormat);

				var constraint = GetConstraintInfo(symbol, behaviorTypeSymbol, cancellationToken);
				if (constraint == null)
					return null;

				cancellationToken.ThrowIfCancellationRequested();
				return new Behavior
				{
					RegistrationType = typeName,
					NonGenericTypeName = constructorType,
					RequestType = constraint.RequestType,
					ResponseType = constraint.ResponseType,
				};
			})
			.ToEquatableReadOnlyList();
	}

	private static ConstraintInfo? GetConstraintInfo(INamedTypeSymbol symbol, ISymbol behaviorTypeSymbol, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var originalDefinition = symbol.OriginalDefinition;

		var requestConstraints = originalDefinition
			.TypeParameters[0]
			.ConstraintTypes;
		if (requestConstraints.Length > 1)
			return null;

		var requestType = requestConstraints.Length == 1
			? requestConstraints[0].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
			: null;

		cancellationToken.ThrowIfCancellationRequested();
		var responseConstraints = originalDefinition
			.TypeParameters[1]
			.ConstraintTypes;
		if (responseConstraints.Length > 1)
			return null;

		var responseType = responseConstraints.Length == 1
			? responseConstraints[0].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
			: null;

		cancellationToken.ThrowIfCancellationRequested();
		if (originalDefinition.BaseType != null
			&& !SymbolEqualityComparer.Default.Equals(originalDefinition.BaseType.OriginalDefinition, behaviorTypeSymbol)
			&& (requestType == null || responseType == null))
		{
			var constraintInfo = GetConstraintInfo(originalDefinition.BaseType, behaviorTypeSymbol, cancellationToken);
			if (constraintInfo == null)
				return null;

			requestType ??= constraintInfo.RequestType;
			responseType ??= constraintInfo.ResponseType;
		}

		return new()
		{
			RequestType = requestType,
			ResponseType = responseType,
		};
	}
}
