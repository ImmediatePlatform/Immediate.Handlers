namespace Immediate.Handlers;

internal static class Utility
{
	public static string? NullIf(this string value, string check) =>
		value.Equals(check, StringComparison.Ordinal) ? null : value;
}
