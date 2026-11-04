using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators;

internal static class TransformBehaviors
{
	public static EquatableReadOnlyList<BehaviorRegistration> ParseBehaviors(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	) => context.Attributes[0].ParseBehaviors(cancellationToken);

	public static EquatableReadOnlyList<BehaviorRegistration> ParseBehaviors(
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
			.Select(v => ParseBehavior(v, cancellationToken))
			.ToEquatableReadOnlyList();
	}

	private static BehaviorRegistration ParseBehavior(TypedConstant value, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var symbol = value.Value as INamedTypeSymbol;
		var typeName = symbol?.ToDisplayString(DisplayNameFormatters.FullyQualifiedWithNullableFormat) ?? "<unresolved behavior>";
		var declaration = symbol?.OriginalDefinition.ToDisplayString(
			DisplayNameFormatters.FullyQualifiedWithNullableFormat.WithGenericsOptions(
				SymbolDisplayGenericsOptions.IncludeTypeParameters | SymbolDisplayGenericsOptions.IncludeTypeConstraints
			)
		) ?? typeName;

		BehaviorRegistration Invalid(string reason) => new()
		{
			TypeName = typeName,
			Declaration = declaration,
			Behavior = null,
			Error = reason,
		};

		if (symbol is null)
			return Invalid("Behavior type could not be resolved.");

		var originalDefinition = symbol.OriginalDefinition;
		if (originalDefinition.TypeParameters.Length > 2)
			return Invalid("Behavior has more than two type parameters.");

		if (originalDefinition.IsGenericType && !symbol.IsUnboundGenericType)
			return Invalid("Generic behavior must be unbound.");

		if (originalDefinition.IsAbstract)
			return Invalid("Behavior is abstract.");

		if (!originalDefinition.ImplementsBehavior())
			return Invalid("Type does not inherit Behavior<,> or StreamingBehavior<,>.");

		var constraintInfo = symbol.GetBehaviorConstraintInfo();
		if (constraintInfo is not { RequestConstraints: { }, ResponseConstraints: { } })
			return Invalid("Request and response constraints could not be resolved.");

		cancellationToken.ThrowIfCancellationRequested();
		return new()
		{
			TypeName = typeName,
			Declaration = declaration,
			Behavior = new()
			{
				NonGenericTypeName = originalDefinition.ToDisplayString(DisplayNameFormatters.NonGenericFqdnFormat),
				RequestType = constraintInfo.RequestConstraints.ToEquatableConstraint(),
				ResponseType = constraintInfo.ResponseConstraints.ToEquatableConstraint(),
				Name = originalDefinition.Name,
				IsStreaming = originalDefinition.ImplementsStreamingBehavior(),
			},
		};
	}
}

file static class Extensions
{
	public static ConstraintInfo ToEquatableConstraint(this Handlers.ConstraintInfo constraint)
	{
		return new()
		{
			ExactType = constraint.ExactType?.ToDisplayString(DisplayNameFormatters.FullyQualifiedWithNullableFormat),

			TypeConstraints = constraint.TypeConstraints
				.Select(tc => tc.OriginalDefinition.ToDisplayString(DisplayNameFormatters.FullyQualifiedWithNullableFormat))
				.ToEquatableReadOnlyList(),
		};
	}
}
