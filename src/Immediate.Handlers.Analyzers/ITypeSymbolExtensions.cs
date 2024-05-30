using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Analyzers;

internal static class ITypeSymbolExtensions
{
	public static bool IsBehaviorsAttribute(this ITypeSymbol? typeSymbol) =>
		typeSymbol is
		{
			Name: "BehaviorsAttribute",
			ContainingNamespace:
			{
				Name: "Shared",
				ContainingNamespace:
				{
					Name: "Handlers",
					ContainingNamespace:
					{
						Name: "Immediate",
						ContainingNamespace.IsGlobalNamespace: true,
					},
				},
			},
		};

	public static bool IsBehavior2(this ITypeSymbol typeSymbol) =>
		typeSymbol is
		{
			MetadataName: "Behavior`2",
			ContainingNamespace:
			{
				Name: "Shared",
				ContainingNamespace:
				{
					Name: "Handlers",
					ContainingNamespace:
					{
						Name: "Immediate",
						ContainingNamespace.IsGlobalNamespace: true,
					},
				},
			},
		};

	public static bool ImplementsBehavior(this INamedTypeSymbol typeSymbol) =>
		typeSymbol.IsBehavior2()
		|| (typeSymbol.BaseType is not null && ImplementsBehavior(typeSymbol.BaseType.OriginalDefinition));
}
