using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;

internal static class ITypeSymbolExtensions
{
	public static bool ImplementsBehavior([NotNullWhen(true)] this INamedTypeSymbol typeSymbol) =>
		typeSymbol.IsBehavior2
		|| (typeSymbol.BaseType is not null && ImplementsBehavior(typeSymbol.BaseType.OriginalDefinition));

	extension([NotNullWhen(true)] ITypeSymbol? typeSymbol)
	{
		public bool IsHandlerAttribute =>
			typeSymbol is INamedTypeSymbol
			{
				Arity: 0,
				Name: "HandlerAttribute",
				ContainingNamespace.IsImmediateHandlersShared: true,
			};

		public bool IsBehaviorsAttribute =>
			typeSymbol is INamedTypeSymbol
			{
				Arity: 0,
				Name: "BehaviorsAttribute",
				ContainingNamespace.IsImmediateHandlersShared: true,
			};

		public bool IsBehavior2 =>
			typeSymbol is INamedTypeSymbol
			{
				Arity: 2,
				Name: "Behavior",
				ContainingNamespace.IsImmediateHandlersShared: true,
			};

		public bool IsIHandler =>
			typeSymbol is INamedTypeSymbol
			{
				Arity: 2,
				Name: "IHandler",
				ContainingNamespace.IsImmediateHandlersShared: true,
			};

		public bool IsIEquatable1 =>
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

		public bool IsValueTask1 =>
			typeSymbol is INamedTypeSymbol
			{
				Arity: 1,
				Name: "ValueTask",
				ContainingNamespace.IsSystemThreadingTasks: true,
			};

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
