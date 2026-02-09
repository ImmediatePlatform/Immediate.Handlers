namespace Immediate.Handlers;

internal static class Utility
{
	public static string? NullIf(this string value, string check) =>
		value.Equals(check, StringComparison.Ordinal) ? null : value;

	public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> values)
		where T : class => values.Where(x => x is not null)!;
}
