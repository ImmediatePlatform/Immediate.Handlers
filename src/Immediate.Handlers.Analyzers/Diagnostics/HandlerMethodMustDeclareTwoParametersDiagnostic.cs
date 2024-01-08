using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Analyzers.Diagnostics;

public static class HandlerMethodMustDeclareTwoParametersDiagnostic
{
	// Preferred format of DiagnosticId is Your Prefix + Number, e.g. CA1234.
	private const string DiagnosticId = "IH0003";

	// Feel free to use raw strings if you don't need localization.
	private static readonly LocalizableString Title = "Method must define two parameters";

	// The message that will be displayed to the user.
	private static readonly LocalizableString MessageFormat = "Method '{0}' must take the request type as it's first parameter and a CancellationToken as it's last parameter";

	private static readonly LocalizableString Description = "HandleAsync method must must take the request type as it's first parameter and a CancellationToken as it's last parameter.";

	// The category of the diagnostic (Design, Naming etc.).
	private const string Category = "Usage";

	public static readonly DiagnosticDescriptor Rule = new(DiagnosticId, Title, MessageFormat, Category,
		DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);
}
