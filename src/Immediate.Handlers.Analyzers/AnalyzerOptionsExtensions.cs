// Copyright @meziantou aka Gérald Barré
// Copied from https://github.com/meziantou/Meziantou.Analyzer/blob/main/src/Meziantou.Analyzer/Configurations/AnalyzerOptionsExtensions.cs

using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

internal static class AnalyzerOptionsExtensions
{
	public static bool GetConfigurationValue(this AnalyzerOptions options, ISymbol symbol, string key, bool defaultValue)
	{
		foreach (var location in symbol.Locations)
		{
			var syntaxTree = location.SourceTree;
			if (syntaxTree is not null && options.TryGetConfigurationValue(syntaxTree, key, out var str))
				return ChangeType(str, defaultValue);
		}

		return defaultValue;
	}

	public static bool TryGetConfigurationValue(this AnalyzerOptions options, SyntaxTree syntaxTree, string key, [NotNullWhen(true)] out string? value)
	{
		var configuration = options.AnalyzerConfigOptionsProvider.GetOptions(syntaxTree);
		return configuration.TryGetValue(key, out value);
	}

	private static bool ChangeType(string value, bool defaultValue)
	{
		if (value is not null && bool.TryParse(value, out var result))
			return result;

		return defaultValue;
	}
}
