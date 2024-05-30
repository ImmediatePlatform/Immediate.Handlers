using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators.ImmediateHandlers;

public partial class ImmediateHandlersGenerator
{
	private static Handler? TransformHandler(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();
		var symbol = (INamedTypeSymbol)context.TargetSymbol;

		var @namespace = symbol.ContainingNamespace.ToString().NullIf("<global namespace>");
		var name = symbol.Name;
		var displayName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

		cancellationToken.ThrowIfCancellationRequested();
		if (symbol.ContainingType is not null)
			return null;

		if (symbol
				.GetMembers()
				.OfType<IMethodSymbol>()
				.Where(m => m.IsStatic)
				.Where(m => m.Name is "Handle" or "HandleAsync")
				.ToList() is not [var handleMethod])
		{
			return null;
		}

		// must have request type and cancellation token
		if (handleMethod.Parameters is [])
			return null;

		if (handleMethod.ReturnsVoid)
			return null;

		cancellationToken.ThrowIfCancellationRequested();

		var requestType = BuildGenericType(handleMethod.Parameters[0].Type);
		var useToken = handleMethod.Parameters[^1]
			.Type.IsCancellationToken();

		cancellationToken.ThrowIfCancellationRequested();
		var responseTypeSymbol = handleMethod.GetTaskReturnType();
		if (responseTypeSymbol is null)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (!handleMethod.ReturnType.IsValueTask())
				return null;
		}

		var responseType = BuildGenericType(responseTypeSymbol);

		cancellationToken.ThrowIfCancellationRequested();
		var parameters = handleMethod.Parameters
			.Skip(1)
			.Take(handleMethod.Parameters.Length - (useToken ? 2 : 1))
			.Select(p => new Parameter
			{
				Type = p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
				Name = p.Name,
			})
			.ToEquatableReadOnlyList();

		cancellationToken.ThrowIfCancellationRequested();
		var behaviors = GetOverrideBehaviors(symbol, cancellationToken);

		cancellationToken.ThrowIfCancellationRequested();
		return new()
		{
			Namespace = @namespace,
			ClassName = name,
			DisplayName = displayName,

			MethodName = handleMethod.Name,
			Parameters = parameters,
			UseToken = useToken,

			RequestType = requestType,
			ResponseType = responseType,

			OverrideBehaviors = behaviors,
		};
	}

	private static EquatableReadOnlyList<Behavior?>? GetOverrideBehaviors(
			INamedTypeSymbol symbol,
			CancellationToken cancellationToken) =>
		symbol.GetAttribute("Immediate.Handlers.Shared.BehaviorsAttribute")
				is { } ba
			? ParseBehaviors(ba, cancellationToken)
			: null;

	[return: NotNullIfNotNull(nameof(type))]
	private static GenericType? BuildGenericType(ITypeSymbol? type)
	{
		if (type == null)
			return null;

		var name = type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

		var implements = new List<string>();
		AddBaseTypes(type, implements);

		return new()
		{
			Name = name,
			Implements = implements.Distinct().ToEquatableReadOnlyList(),
		};
	}

	private static void AddBaseTypes(ITypeSymbol type, List<string> implements)
	{
		if (type.SpecialType is SpecialType.System_Object or SpecialType.System_Collections_IEnumerable
			|| type.IsIEquatable1())
		{
			return;
		}

		implements.Add(type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat));
		if (type.BaseType is not null)
			AddBaseTypes(type.BaseType, implements);

		foreach (var i in type.Interfaces)
			AddBaseTypes(i, implements);
	}
}
