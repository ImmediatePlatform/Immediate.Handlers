using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators;

internal static class Utility
{
	public static ITypeSymbol? GetTaskReturnType(this IMethodSymbol method) =>
		method.ReturnType.IsValueTask1()
			? ((INamedTypeSymbol)method.ReturnType).TypeArguments.FirstOrDefault()
			: null;

	public static AttributeData? GetAttribute(this INamedTypeSymbol symbol, string attribute) =>
		symbol
			.GetAttributes()
			.FirstOrDefault(a =>
				a.AttributeClass?.ToString() == attribute
			);

	public static string? NullIf(this string value, string check) =>
		value.Equals(check, StringComparison.Ordinal) ? null : value;
}
