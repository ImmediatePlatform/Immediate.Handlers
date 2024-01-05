using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;

internal static class Utility
{
	public static bool ImplementsBaseClass(this INamedTypeSymbol typeSymbol, INamedTypeSymbol typeToCheck) =>
		SymbolEqualityComparer.Default.Equals(typeSymbol, typeToCheck)
		|| (typeSymbol.BaseType is not null
			&& ImplementsBaseClass(typeSymbol.BaseType.OriginalDefinition, typeToCheck)
		   );
}
