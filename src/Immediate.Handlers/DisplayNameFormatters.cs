using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;
internal class DisplayNameFormatters
{
	public static SymbolDisplayFormat NonGenericFqdnFormat = new SymbolDisplayFormat(
		globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included,
		typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
		genericsOptions: SymbolDisplayGenericsOptions.None // This excludes the generic type arguments
	);
}
