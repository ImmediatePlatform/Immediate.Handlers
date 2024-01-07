using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Analyzers.Diagnostics;

public static class HandlerMethodMustReturnTaskTDiagnostic
{
	// Preferred format of DiagnosticId is Your Prefix + Number, e.g. CA1234.
	private const string DiagnosticId = "IH0002";

	// Feel free to use raw strings if you don't need localization.
	private static readonly LocalizableString Title = ResourceHelpers.GetResourceString(nameof(Resources.IH0002Title));

	// The message that will be displayed to the user.
	private static readonly LocalizableString MessageFormat = ResourceHelpers.GetResourceString(nameof(Resources.IH0002MessageFormat));

	private static readonly LocalizableString Description = ResourceHelpers.GetResourceString(nameof(Resources.IH0002Description));

	// The category of the diagnostic (Design, Naming etc.).
	private const string Category = "Usage";

	public static readonly DiagnosticDescriptor Rule = new(DiagnosticId, Title, MessageFormat, Category,
		DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);
}
