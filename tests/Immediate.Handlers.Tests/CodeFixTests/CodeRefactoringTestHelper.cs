using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis.CodeRefactorings;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.CodeFixTests;

public static class CodeRefactoringTestHelper
{
	private const string EditorConfig =
		"""
	    root = true

	    [*.cs]
	    charset = utf-8
	    indent_style = tab
	    insert_final_newline = true
	    indent_size = 4
	    """;

	public static CSharpCodeRefactoringTest<TRefactoring, DefaultVerifier> CreateCodeRefactoringTest<TRefactoring>(
		[StringSyntax("c#-test")] string inputSource,
		[StringSyntax("c#-test")] string fixedSource,
		int codeActionIndex = 0
	)
		where TRefactoring : CodeRefactoringProvider, new()
	{
		var csTest = new CSharpCodeRefactoringTest<TRefactoring, DefaultVerifier>
		{
			CodeActionIndex = codeActionIndex,
			TestState =
			{
				Sources = { inputSource },
				AnalyzerConfigFiles = { { ("/.editorconfig", EditorConfig) } },
				ReferenceAssemblies = new ReferenceAssemblies(
					"net8.0",
					new PackageIdentity(
						"Microsoft.NETCore.App.Ref",
						"8.0.0"),
					Path.Combine("ref", "net8.0")
				),
			},
			FixedState = { MarkupHandling = MarkupMode.IgnoreFixable, Sources = { fixedSource } },
		};

		csTest.TestState.AdditionalReferences
			.AddRange(DriverReferenceAssemblies.Msdi.GetAdditionalReferences());

		return csTest;
	}
}
