using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators;

internal static class ITypeSymbolExtensions
{
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

	public static bool IsValueTask1(this ITypeSymbol typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			MetadataName: "ValueTask`1",
			ContainingNamespace:
			{
				Name: "Tasks",
				ContainingNamespace:
				{
					Name: "Threading",
					ContainingNamespace:
					{
						Name: "System",
						ContainingNamespace.IsGlobalNamespace: true
					}
				}
			}
		};

	public static bool IsValueTask(this ITypeSymbol typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Name: "ValueTask",
			ContainingNamespace:
			{
				Name: "Tasks",
				ContainingNamespace:
				{
					Name: "Threading",
					ContainingNamespace:
					{
						Name: "System",
						ContainingNamespace.IsGlobalNamespace: true
					}
				}
			}
		};

	public static bool IsIEquatable1(this ITypeSymbol typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			MetadataName: "IEquatable`1",
			ContainingNamespace:
			{
				Name: "System",
				ContainingNamespace.IsGlobalNamespace: true
			},
		};

	public static bool IsCancellationToken(this ITypeSymbol typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Name: "CancellationToken",
			ContainingNamespace:
			{
				Name: "Threading",
				ContainingNamespace:
				{
					Name: "System",
					ContainingNamespace.IsGlobalNamespace: true
				}
			}
		};
}
