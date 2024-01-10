using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators;

internal static class Utility
{
	public static bool ImplementsBaseClass(this INamedTypeSymbol typeSymbol, INamedTypeSymbol typeToCheck) =>
		SymbolEqualityComparer.Default.Equals(typeSymbol, typeToCheck)
		|| (typeSymbol.BaseType is not null
			&& ImplementsBaseClass(typeSymbol.BaseType.OriginalDefinition, typeToCheck)
		   );

	public static ITypeSymbol? GetTaskReturnType(this IMethodSymbol method, INamedTypeSymbol taskSymbol) =>
		!method.ReturnsVoid && SymbolEqualityComparer.Default.Equals(method.ReturnType.OriginalDefinition, taskSymbol)
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
