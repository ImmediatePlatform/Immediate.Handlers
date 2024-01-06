using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;

internal static class Utility
{
	public static bool ImplementsBaseClass(this INamedTypeSymbol typeSymbol, INamedTypeSymbol typeToCheck) =>
		SymbolEqualityComparer.Default.Equals(typeSymbol, typeToCheck)
		|| (typeSymbol.BaseType is not null
			&& ImplementsBaseClass(typeSymbol.BaseType.OriginalDefinition, typeToCheck)
		   );

	public static ITypeSymbol? GetTaskReturnType(this IMethodSymbol method) =>
		method.ReturnsVoid || method.ReturnType.OriginalDefinition.ToString() != "System.Threading.Tasks.Task<TResult>"
			? null
			: ((INamedTypeSymbol)method.ReturnType).TypeArguments.FirstOrDefault();

	public static AttributeData? GetAttribute(this INamedTypeSymbol symbol, string attribute) =>
		symbol
			.GetAttributes()
			.FirstOrDefault(a =>
				a.AttributeClass?.ToString() == attribute
			);
}
