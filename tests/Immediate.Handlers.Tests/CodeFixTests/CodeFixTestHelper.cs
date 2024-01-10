using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.CodeFixTests;

public static class CodeFixTestHelper
{
	private const string EditorConfig = """
		root = true

		[*.cs]
		charset = utf-8
		end_of_line = lf
		indent_style = tab
		insert_final_newline = true
		indent_size = 4
		""";

	public static CSharpCodeFixTest<TAnalyzer, TCodeFix, DefaultVerifier> CreateCodeFixTest<TAnalyzer, TCodeFix>(
		string inputSource,
		string fixedSource,
		DriverReferenceAssemblies assemblies,
		int codeActionIndex = 0
	)
		where TAnalyzer : DiagnosticAnalyzer, new()
		where TCodeFix : CodeFixProvider, new()
	{
		var csTest = new CSharpCodeFixTest<TAnalyzer, TCodeFix, DefaultVerifier>
		{
			CodeActionIndex = codeActionIndex,
			TestState =
			{
				Sources = { inputSource },
				AnalyzerConfigFiles =
				{
					{ ("/.editorconfig", EditorConfig) },
				},
			},
			FixedState =
			{
				MarkupHandling = MarkupMode.IgnoreFixable,
				Sources = { fixedSource },
			},
		};

		csTest.TestState.AdditionalReferences
			.AddRange(assemblies.GetAdditionalReferences());

		return csTest;
	}

}
