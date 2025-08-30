using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;

internal static class ITypeSymbolExtensions
{
	public static bool IsHandlerAttribute(this ITypeSymbol? typeSymbol) =>
		typeSymbol is
		{
			Name: "HandlerAttribute",
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
		typeSymbol is INamedTypeSymbol
		{
			Arity: 2,
			Name: "Behavior",
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
			Arity: 1,
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
			Arity: 1,
			Name: "IEquatable",
			ContainingNamespace:
			{
				Name: "System",
				ContainingNamespace.IsGlobalNamespace: true
			},
		};

	public static bool IsCancellationToken(this ITypeSymbol? typeSymbol) =>
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

	public static bool IsIHandler([NotNullWhen(true)] this ITypeSymbol? typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Arity: 2,
			Name: "IHandler",
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
}
