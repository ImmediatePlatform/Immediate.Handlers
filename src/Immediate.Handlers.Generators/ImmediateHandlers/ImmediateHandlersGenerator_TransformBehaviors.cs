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

		return ParseBehaviors(context.Attributes[0], cancellationToken);
	}

	private static EquatableReadOnlyList<Behavior?> ParseBehaviors(
		AttributeData attribute,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();

		if (attribute.ConstructorArguments.Length != 1)
			return [];

		var ca = attribute.ConstructorArguments[0];
		if (ca.Type is not IArrayTypeSymbol
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
			})
		{
			return [];
		}

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

				if (!originalDefinition.ImplementsBehavior())
					return null;

				cancellationToken.ThrowIfCancellationRequested();

				// global::Dummy.LoggingBehavior<,>
				// for: `services.AddScoped(typeof(..));`
				var typeName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

				cancellationToken.ThrowIfCancellationRequested();

				// global::Dummy.LoggingBehavior
				// for: private readonly global::Dummy.LoggingBehavior
				var constructorType = symbol.OriginalDefinition.ToDisplayString(DisplayNameFormatters.NonGenericFqdnFormat);

				var constraint = GetConstraintInfo(symbol, cancellationToken);
				if (constraint == null)
					return null;

				cancellationToken.ThrowIfCancellationRequested();
				return new Behavior
				{
					RegistrationType = typeName,
					NonGenericTypeName = constructorType,
					RequestType = constraint.RequestType,
					ResponseType = constraint.ResponseType,
					Name = originalDefinition.Name,
				};
			})
			.ToEquatableReadOnlyList();
	}

	private static ConstraintInfo? GetConstraintInfo(INamedTypeSymbol symbol, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var originalDefinition = symbol.OriginalDefinition;

		if (GetConstraintType(originalDefinition.TypeParameters[0]) is not (true, var requestType))
			return null;

		cancellationToken.ThrowIfCancellationRequested();

		if (GetConstraintType(originalDefinition.TypeParameters[1]) is not (true, var responseType))
			return null;

		cancellationToken.ThrowIfCancellationRequested();

		return new()
		{
			RequestType = requestType,
			ResponseType = responseType,
		};
	}

	private static (bool Valid, string? Constraint) GetConstraintType(ITypeParameterSymbol parameter)
	{
		if (parameter.ConstraintTypes is [])
			return (true, null);

		if (parameter.ConstraintTypes is not [var constraint])
			return default;

		var displayString = constraint.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

		if (constraint is INamedTypeSymbol
			{
				IsGenericType: true,
				TypeArguments:
				[
					ITypeParameterSymbol s,
				]
			}
			&& s.Name == parameter.Name
		)
		{
			displayString = displayString.Replace(parameter.Name, "_TRequest_");
		}

		return (true, displayString);
	}
}
