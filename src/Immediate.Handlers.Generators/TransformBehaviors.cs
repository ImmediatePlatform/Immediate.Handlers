using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators;

internal static class TransformBehaviors
{
	public static EquatableReadOnlyList<Behavior?> ParseBehaviors(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	) => context.Attributes[0].ParseBehaviors(cancellationToken);

	public static EquatableReadOnlyList<Behavior?> ParseBehaviors(
		this AttributeData attribute,
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

				var originalDefinition = symbol.OriginalDefinition;

				// Accept behaviors with 0, 1, or 2 type parameters
				var typeParamCount = originalDefinition.TypeParameters.Length;
				if (typeParamCount > 2)
					return null;

				// For generic types, must be unbound. For non-generic types, this check doesn't apply
				if (originalDefinition.IsGenericType && !symbol.IsUnboundGenericType)
					return null;

				if (originalDefinition.IsAbstract)
					return null;

				if (!originalDefinition.ImplementsBehavior())
					return null;

				cancellationToken.ThrowIfCancellationRequested();

				// global::Dummy.LoggingBehavior<,> or global::Dummy.LoggingBehavior<> or global::Dummy.LoggingBehavior
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
					TypeParameterCount = typeParamCount,
				};
			})
			.ToEquatableReadOnlyList();
	}

	private static ConstraintInfo? GetConstraintInfo(INamedTypeSymbol symbol, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var originalDefinition = symbol.OriginalDefinition;
		var typeParamCount = originalDefinition.TypeParameters.Length;

		// Handle different numbers of generic parameters
		if (typeParamCount == 0)
		{
			// Non-generic behavior - no constraints
			return new()
			{
				RequestType = null,
				ResponseType = null,
			};
		}

		if (typeParamCount == 1)
		{
			// Single generic parameter - need to determine if it's request or response
			// by looking at which position of Behavior<TRequest, TResponse> it maps to
			var behaviorBaseType = FindBehaviorBaseType(originalDefinition);
			if (behaviorBaseType is null || behaviorBaseType.TypeArguments.Length != 2)
				return null;

			var typeParam = originalDefinition.TypeParameters[0];
			var requestTypeArg = behaviorBaseType.TypeArguments[0];
			var responseTypeArg = behaviorBaseType.TypeArguments[1];

			cancellationToken.ThrowIfCancellationRequested();

			// Check if the type parameter is used in the request position
			if (requestTypeArg is ITypeParameterSymbol reqParam &&
				SymbolEqualityComparer.Default.Equals(reqParam.OriginalDefinition, typeParam))
			{
				// Type parameter is in request position
				if (GetConstraintType(typeParam) is not (true, var paramType))
					return null;

				return new()
				{
					RequestType = paramType,
					ResponseType = GetFixedType(responseTypeArg),
				};
			}

			// Check if the type parameter is used in the response position
			if (responseTypeArg is ITypeParameterSymbol respParam &&
				SymbolEqualityComparer.Default.Equals(respParam.OriginalDefinition, typeParam))
			{
				// Type parameter is in response position
				if (GetConstraintType(typeParam) is not (true, var paramType))
					return null;

				return new()
				{
					RequestType = GetFixedType(requestTypeArg),
					ResponseType = paramType,
				};
			}

			// Type parameter is not used in either position - invalid
			return null;
		}

		// typeParamCount == 2
		// Two generic parameters - request and response
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

	private static string? GetFixedType(ITypeSymbol typeArg)
	{
		// If it's a type parameter, return null (no constraint)
		if (typeArg is ITypeParameterSymbol)
			return null;

		// It's a fixed type, return its fully qualified name
		return typeArg.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
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
			&& s.Name.Equals(parameter.Name, StringComparison.OrdinalIgnoreCase)
		)
		{
			displayString = displayString.Replace(parameter.Name, "_TRequest_");
		}

		return (true, displayString);
	}
}
