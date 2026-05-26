using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers;

internal static class Utility
{
	public static string? NullIf(this string value, string check) =>
		value.Equals(check, StringComparison.Ordinal) ? null : value;

	public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> values)
		where T : class => values.Where(x => x is not null)!;

	public static string GetAssemblyPrefix(Compilation compilation)
	{
		if (compilation.Assembly.GetAttributes()
				.FirstOrDefault(a => a.AttributeClass.IsImmediatePrefixAttribute)
				is { ConstructorArguments: [{ Value: string prefix }] }
			&& IsValidIdentifier(prefix))
		{
			return prefix;
		}

		return compilation.AssemblyName!
			.Replace(".", string.Empty)
			.Replace(" ", string.Empty)
			.Trim();
	}

	public static bool IsValidIdentifier(string? value)
	{
		if (string.IsNullOrWhiteSpace(value))
			return false;

		if (!SyntaxFacts.IsIdentifierStartCharacter(value![0]))
			return false;

		for (var i = 1; i < value.Length; i++)
		{
			if (!SyntaxFacts.IsIdentifierPartCharacter(value[i]))
				return false;
		}

		return true;
	}
}
