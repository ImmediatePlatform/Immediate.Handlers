using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers;

internal static class TypedConstantExtensions
{
	public static TypedConstant? GetArgumentValue(this ImmutableArray<KeyValuePair<string, TypedConstant>> arguments, string name)
	{
		foreach (var argument in arguments)
		{
			if (string.Equals(name, argument.Key, StringComparison.Ordinal))
				return argument.Value;
		}

		return null;
	}

	public static string? GetEnumArgumentValue(this ImmutableArray<KeyValuePair<string, TypedConstant>> arguments, string name) =>
		arguments.GetArgumentValue(name)?.GetEnumValueName();

	extension(TypedConstant constant)
	{
		public string GetEnumValueName()
		{
			var fullName = constant.ToCSharpString();
			var start = fullName.LastIndexOf('.');
			return fullName[(start + 1)..];
		}

		public string? GetStringArray()
		{
			if (constant.Kind != TypedConstantKind.Array)
				return null;

			return string.Join(
				", ",
				constant.Values
					.Select(tc => tc.ToCSharpString())
					.OrderBy(x => x, StringComparer.Ordinal)
			);
		}

		public INamedTypeSymbol? ArgumentType =>
			constant switch
			{
				{ Kind: TypedConstantKind.Type, Value: INamedTypeSymbol type } => type,
				_ => null,
			};
	}
}
