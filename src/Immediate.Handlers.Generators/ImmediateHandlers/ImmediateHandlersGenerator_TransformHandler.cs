using Immediate.Handlers.Shared;
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
				.Where(m =>
					m.Name.Equals("Handle", StringComparison.Ordinal)
					|| m.Name.Equals("HandleAsync", StringComparison.Ordinal)
				)
				.ToList() is not [var handleMethod])
		{
			return null;
		}

		// must have request type and cancellation token
		if (handleMethod.Parameters.Length < 2)
			return null;

		cancellationToken.ThrowIfCancellationRequested();
		var requestType = BuildGenericType((INamedTypeSymbol)handleMethod.Parameters[0].Type);

		var compilation = context.SemanticModel.Compilation;
		var taskSymbol = compilation.GetTypeByMetadataName("System.Threading.Tasks.ValueTask`1")!;

		cancellationToken.ThrowIfCancellationRequested();
		var responseTypeSymbol = handleMethod.GetTaskReturnType(taskSymbol);
		if (responseTypeSymbol is null)
			return null;

		var responseType = BuildGenericType((INamedTypeSymbol)responseTypeSymbol);

		cancellationToken.ThrowIfCancellationRequested();
		var parameters = handleMethod.Parameters
			.Skip(1).Take(handleMethod.Parameters.Length - 2)
			.Select(p => new Parameter
			{
				Type = p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
				Name = p.Name,
			})
			.ToEquatableReadOnlyList();

		cancellationToken.ThrowIfCancellationRequested();
		var renderMode = GetOverrideRenderMode(symbol);

		cancellationToken.ThrowIfCancellationRequested();
		var behaviors = GetOverrideBehaviors(symbol, context.SemanticModel.Compilation, cancellationToken);

		cancellationToken.ThrowIfCancellationRequested();
		return new()
		{
			Namespace = @namespace,
			ClassName = name,
			DisplayName = displayName,

			MethodName = handleMethod.Name,

			RequestType = requestType,
			ResponseType = responseType,

			Parameters = parameters,

			OverrideRenderMode = renderMode,
			OverrideBehaviors = behaviors,
		};
	}

	private static RenderMode? GetOverrideRenderMode(INamedTypeSymbol symbol) =>
		symbol.GetAttribute("Immediate.Handlers.Shared.RenderModeAttribute")
				is { } rma
			? ParseRenderMode(rma)
			: null;

	private static EquatableReadOnlyList<Behavior?>? GetOverrideBehaviors(
			INamedTypeSymbol symbol,
			Compilation compilation,
			CancellationToken cancellationToken) =>
		symbol.GetAttribute("Immediate.Handlers.Shared.BehaviorsAttribute")
				is { } ba
			? ParseBehaviors(ba, compilation, cancellationToken)
			: null;

	private static GenericType BuildGenericType(ITypeSymbol type)
	{
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
		if (type.OriginalDefinition.ToString() is
				"object"
				or "System.Collections.IEnumerable"
				or "System.IEquatable<T>"
		)
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
