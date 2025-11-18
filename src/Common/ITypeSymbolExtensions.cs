using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;

internal static class ITypeSymbolExtensions
{
	public static bool IsHandlerAttribute([NotNullWhen(true)] this ITypeSymbol? typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Arity: 0,
			Name: "HandlerAttribute",
			ContainingNamespace.IsImmediateHandlersShared: true,
		};

	public static bool IsBehavior2([NotNullWhen(true)] this ITypeSymbol typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Arity: 2,
			Name: "Behavior",
			ContainingNamespace.IsImmediateHandlersShared: true,
		};

	public static bool IsBehaviorsAttribute([NotNullWhen(true)] this ITypeSymbol? typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Arity: 0,
			Name: "BehaviorsAttribute",
			ContainingNamespace.IsImmediateHandlersShared: true,
		};

	public static bool IsIHandler([NotNullWhen(true)] this ITypeSymbol? typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Arity: 2,
			Name: "IHandler",
			ContainingNamespace.IsImmediateHandlersShared: true,
		};

	public static bool ImplementsBehavior([NotNullWhen(true)] this INamedTypeSymbol typeSymbol) =>
		typeSymbol.IsBehavior2()
		|| (typeSymbol.BaseType is not null && ImplementsBehavior(typeSymbol.BaseType.OriginalDefinition));

	public static bool IsValueTask1([NotNullWhen(true)] this ITypeSymbol? typeSymbol) =>
		typeSymbol is INamedTypeSymbol
		{
			Arity: 1,
			Name: "ValueTask",
			ContainingNamespace.IsSystemThreadingTasks: true,
		};

	public static bool IsIEquatable1([NotNullWhen(true)] this ITypeSymbol? typeSymbol) =>
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

	extension(ITypeSymbol? typeSymbol)
	{
		public bool IsCancellationToken =>
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

	extension(INamespaceSymbol namespaceSymbol)
	{
		public bool IsSystemThreadingTasks =>
			namespaceSymbol is
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
				},
			};

		public bool IsImmediateHandlersShared =>
			namespaceSymbol is
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
			};
	}
}
