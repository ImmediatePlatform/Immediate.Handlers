using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers;

internal static class ITypeSymbolExtensions
{
	extension(INamedTypeSymbol typeSymbol)
	{
		public bool ImplementsBehavior() =>
			typeSymbol.IsBehavior2
			|| (typeSymbol.BaseType is not null && ImplementsBehavior(typeSymbol.BaseType.OriginalDefinition));

		public BehaviorConstraintInfo? GetBehaviorConstraintInfo()
		{
			var constraints = GetBaseConstraints(typeSymbol.OriginalDefinition);

			var requestConstraints = constraints?.Find(c => c.Item1 == 1).Item2;
			var responseConstraints = constraints?.Find(c => c.Item1 == 2).Item2;

			if (requestConstraints is null || responseConstraints is null)
				return null;

			return new()
			{
				RequestConstraints = requestConstraints,
				ResponseConstraints = responseConstraints,
			};

			static List<(int, ConstraintInfo)>? GetBaseConstraints(INamedTypeSymbol typeSymbol)
			{
				if (typeSymbol.SpecialType is SpecialType.System_Object)
					return null;

				if (typeSymbol.IsBehavior2)
				{
					return
					[
						(1, ConstraintInfo.Empty),
						(2, ConstraintInfo.Empty),
					];
				}

				if (typeSymbol.BaseType is not { } baseType)
					return null;

				var baseOriginal = baseType.OriginalDefinition;

				if (GetBaseConstraints(baseOriginal) is not { } baseConstraints)
					return null;

				var constraints = new List<(int, ConstraintInfo)>();

				// load all type parameters
				foreach (var parameter in typeSymbol.TypeParameters)
				{
					var index = baseType.TypeArguments.IndexOf(parameter);
					if (index < 0)
					{
						// don't care about constraints. fail if not resolved
						// otherwise, compiler will handle for us
						constraints.Add((0, ConstraintInfo.Empty));
						continue;
					}

					var (name, constraint) = baseConstraints[index];
					if (name is 0)
					{
						// don't care about constraints. fail if not resolved
						// otherwise, compiler will handle for us
						constraints.Add((0, ConstraintInfo.Empty));
						continue;
					}

					var constraintTypes = (constraint.TypeConstraints, parameter.ConstraintTypes) switch
					{
						([], _) => parameter.ConstraintTypes,
						(_, []) => constraint.TypeConstraints,
						(_, _) => [.. parameter.ConstraintTypes, .. constraint.TypeConstraints],
					};

					constraints.Add((name, new() { ExactType = null, TypeConstraints = constraintTypes }));
				}

				// look for missing trequest or tresponse
				AddMissingConstraint(1, constraints, baseConstraints, baseType);
				AddMissingConstraint(2, constraints, baseConstraints, baseType);

				static void AddMissingConstraint(
					int name,
					List<(int, ConstraintInfo)> constraints,
					List<(int, ConstraintInfo)> baseConstraints,
					INamedTypeSymbol baseType
				)
				{
					if (constraints.Exists(c => c.Item1 == name))
						return;

					var index = baseConstraints.FindIndex(c => c.Item1 == name);
					if (index < 0)
						return; // something wrong here

					constraints.Add(
						baseConstraints[index].Item2.ExactType != null
							? baseConstraints[index]
							: (name, new() { ExactType = baseType.TypeArguments[index], TypeConstraints = [] })
					);
				}

				return constraints;
			}
		}
	}

	extension(ITypeSymbol typeSymbol)
	{

		public bool Satisfies(ConstraintInfo? constraints, Compilation compilation)
		{
			if (constraints is null)
				return true;

			if (constraints.ExactType is not null)
				return SymbolEqualityComparer.Default.Equals(constraints.ExactType, typeSymbol);

			foreach (var constraint in constraints.TypeConstraints)
			{
				if (compilation.ClassifyConversion(typeSymbol, constraint)
					is not ({ IsIdentity: true } or { IsImplicit: true, IsReference: true }))
				{
					return false;
				}
			}

			return true;
		}
	}

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

		public bool IsValidHandlerReturn =>
			typeSymbol is INamedTypeSymbol
			{
				Arity: 0 or 1,
				Name: "ValueTask",
				ContainingNamespace.IsSystemThreadingTasks: true,
			};

		public bool IsValueTask1 =>
			typeSymbol is INamedTypeSymbol
			{
				Arity: 1,
				Name: "ValueTask",
				ContainingNamespace.IsSystemThreadingTasks: true,
			};

		public ITypeSymbol? ValueTaskReturnType =>
			typeSymbol.IsValueTask1
				? ((INamedTypeSymbol)typeSymbol).TypeArguments.FirstOrDefault()
				: null;

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
