using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers.Generators;

internal static class TransformHandler
{
	public static Handler? ParseHandler(
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

		var handleMethod = symbol.GetHandleMethod();

		if (handleMethod
				// no potential candidates
				is null
				// no parameters
				or { Parameters: [] }
				// not a valuetask return
				or { ReturnType.IsValidHandlerReturn: false }
				// only private methods are considered
				or { DeclaredAccessibility: not Accessibility.Private })
		{
			return null;
		}

		cancellationToken.ThrowIfCancellationRequested();

		var requestType = BuildGenericType(handleMethod.Parameters[0].Type);
		var isStatic = handleMethod.IsStatic;
		var useToken = handleMethod.Parameters[^1]
			.Type.IsCancellationToken;

		var isParameterCountValid =
			(isStatic, useToken) switch
			{
				(true, true) => handleMethod.Parameters.Length >= 2,
				(true, false) => handleMethod.Parameters.Length >= 1,
				(false, true) => handleMethod.Parameters.Length == 2,
				_ => handleMethod.Parameters.Length == 1,
			};

		if (!isParameterCountValid)
			return null;

		cancellationToken.ThrowIfCancellationRequested();

		var responseType = BuildGenericType(handleMethod.ReturnType.ValueTaskReturnType);

		cancellationToken.ThrowIfCancellationRequested();

		var parameters = handleMethod.Parameters
			.Skip(1)
			.Take(handleMethod.Parameters.Length - (useToken ? 2 : 1))
			.Select(p => new Parameter
			{
				Attributes = p.GetAttributesString(),
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
			IsStatic = isStatic,
			UseToken = useToken,

			RequestType = requestType,
			ResponseType = responseType,

			OverrideBehaviors = behaviors,
		};
	}

	private static EquatableReadOnlyList<Behavior?>? GetOverrideBehaviors(
			INamedTypeSymbol symbol,
			CancellationToken cancellationToken) =>
		symbol.GetBehaviorsAttribute() is { } ba
			? ba.ParseBehaviors(cancellationToken)
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
			Implements = implements.Distinct(StringComparer.Ordinal).ToEquatableReadOnlyList(),
		};
	}

	private static void AddBaseTypes(ITypeSymbol type, List<string> implements)
	{
		if (type
				is { SpecialType: SpecialType.System_Object or SpecialType.System_Collections_IEnumerable }
				or { IsIEquatable1: true })
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

file static class Extensions
{
	public static IMethodSymbol? GetHandleMethod(this INamedTypeSymbol symbol)
	{
		var candidates = symbol
			.GetMembers()
			.OfType<IMethodSymbol>()
			.Where(m => m.Name is "Handle" or "HandleAsync")
			.Take(2)
			.ToList();

		if (candidates.Count == 1)
			return candidates[0];

		return null;
	}

	public static AttributeData? GetBehaviorsAttribute(this INamedTypeSymbol symbol)
	{
		foreach (var a in symbol.GetAttributes())
		{
			if (a.AttributeClass is null)
				continue;

			if (a is { AttributeClass.IsBehaviorsAttribute: true })
				return a;

			foreach (var aa in a.AttributeClass.GetAttributes())
			{
				if (aa is { AttributeClass.IsBehaviorsAttribute: true })
					return aa;
			}
		}

		return null;
	}

	public static string? GetAttributesString(this IParameterSymbol parameter)
	{
		var attributes = parameter.GetAttributes();
		if (attributes.Length == 0)
			return null;

		return $"[{string.Join(", ", attributes.Select(GetAttributeString))}] ";
	}

	private static string GetAttributeString(AttributeData attributeData)
	{
		var @class = attributeData.AttributeClass!.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

		var parameters = new List<string>();

		foreach (var tc in attributeData.ConstructorArguments)
		{
			if (tc.GetTypedConstantString() is { } str)
				parameters.Add(str);
		}

		foreach (var na in attributeData.NamedArguments)
		{
			if (na.Value.GetTypedConstantString() is { } str)
				parameters.Add($"{na.Key} = {str}");
		}

		return parameters.Count == 0
			? @class
			: $"{@class}({string.Join(", ", parameters)})";
	}

	[SuppressMessage("Style", "IDE0072:Add missing cases")]
	private static string? GetTypedConstantString(this TypedConstant tc) =>
		tc.Kind switch
		{
			TypedConstantKind.Array => $"[{string.Join(", ", tc.Values.Select(GetTypedConstantString))}]",
			_ => tc.ToCSharpString(),
		};
}
