using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators;

internal static class DisplayNameFormatters
{
	public static SymbolDisplayFormat NonGenericFqdnFormat = new(
		globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included,
		typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
		genericsOptions: SymbolDisplayGenericsOptions.None // This excludes the generic type arguments
	);
}
