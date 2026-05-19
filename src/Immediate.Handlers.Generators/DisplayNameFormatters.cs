using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators;

internal static class DisplayNameFormatters
{
	public static readonly SymbolDisplayFormat NonGenericFqdnFormat = new(
		globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included,
		typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
		genericsOptions: SymbolDisplayGenericsOptions.None // This excludes the generic type arguments
	);

	public static readonly SymbolDisplayFormat FullyQualifiedWithNullableFormat =
		SymbolDisplayFormat.FullyQualifiedFormat
			.WithMiscellaneousOptions(
				SymbolDisplayFormat.FullyQualifiedFormat.MiscellaneousOptions
				| SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier
			);

}
