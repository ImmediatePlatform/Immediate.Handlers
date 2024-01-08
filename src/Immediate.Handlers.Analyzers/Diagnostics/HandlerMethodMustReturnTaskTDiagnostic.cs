using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Analyzers.Diagnostics;

public static class HandlerMethodMustReturnTaskTDiagnostic
{
	// Preferred format of DiagnosticId is Your Prefix + Number, e.g. CA1234.
	private const string DiagnosticId = "IH0002";

	// Feel free to use raw strings if you don't need localization.
	private static readonly LocalizableString Title = "Method must return a Task<T>";

	// The message that will be displayed to the user.
	private static readonly LocalizableString MessageFormat = "Method '{0}' must return a Task<T>";

	private static readonly LocalizableString Description = "HandleAsync method must return a Task<T>.";

	// The category of the diagnostic (Design, Naming etc.).
	private const string Category = "Usage";

	public static readonly DiagnosticDescriptor Rule = new(DiagnosticId, Title, MessageFormat, Category,
		DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);
}
