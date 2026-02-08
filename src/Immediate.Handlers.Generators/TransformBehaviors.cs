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
				if (originalDefinition.TypeParameters.Length > 2)
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

				var constraintInfo = symbol.GetBehaviorConstraintInfo();
				if (constraintInfo is not { RequestConstraints: { }, ResponseConstraints: { } })
					return null;

				cancellationToken.ThrowIfCancellationRequested();
				return new Behavior
				{
					RegistrationType = typeName,
					NonGenericTypeName = constructorType,
					RequestType = constraintInfo.RequestConstraints.ToEquatableConstraint(),
					ResponseType = constraintInfo.ResponseConstraints.ToEquatableConstraint(),
					Name = originalDefinition.Name,
				};
			})
			.ToEquatableReadOnlyList();
	}
}

file static class Extensions
{
	public static ConstraintInfo ToEquatableConstraint(this Handlers.ConstraintInfo constraint)
	{
		return new()
		{
			ExactType = constraint.ExactType?.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),

			TypeConstraints = constraint.TypeConstraints
				.Select(tc => tc.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
				.ToEquatableReadOnlyList(),
		};
	}
}
