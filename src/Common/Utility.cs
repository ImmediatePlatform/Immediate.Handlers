using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;

internal static class Utility
{
	public static ITypeSymbol? GetTaskReturnType(this IMethodSymbol method) =>
		method.ReturnType.IsValueTask1
			? ((INamedTypeSymbol)method.ReturnType).TypeArguments.FirstOrDefault()
			: null;

	public static string? NullIf(this string value, string check) =>
		value.Equals(check, StringComparison.Ordinal) ? null : value;
}
