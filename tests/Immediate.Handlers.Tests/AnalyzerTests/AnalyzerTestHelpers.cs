using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public static class AnalyzerTestHelpers
{
	public static CSharpAnalyzerTest<TAnalyzer, DefaultVerifier> CreateAnalyzerTest<TAnalyzer>(string inputSource, IEnumerable<DiagnosticResult> expectedDiagnostics)
		where TAnalyzer : DiagnosticAnalyzer, new()
	{
		var csTest = new CSharpAnalyzerTest<TAnalyzer, DefaultVerifier>
		{
			TestState =
			{
				Sources = { inputSource },
			},
		};

		csTest.TestState.AdditionalReferences.AddRange([MetadataReference.CreateFromFile("./Immediate.Handlers.Shared.dll")]);
		csTest.ExpectedDiagnostics.AddRange(expectedDiagnostics);

		return csTest;
	}

	public static CSharpCodeFixTest<TAnalyzer, TCodeFix, DefaultVerifier> CreateCodeFixTest<TAnalyzer, TCodeFix>(string inputSource, string fixedSource, IEnumerable<DiagnosticResult> expectedDiagnostics)
		where TAnalyzer : DiagnosticAnalyzer, new()
		where TCodeFix : CodeFixProvider, new()
	{
		var csTest = new CSharpCodeFixTest<TAnalyzer, TCodeFix, DefaultVerifier>
		{
			TestState =
			{
				Sources = { inputSource },
			},
			FixedState =
			{
				Sources = { fixedSource },
			},
		};

		csTest.TestState.AdditionalReferences.AddRange([MetadataReference.CreateFromFile("./Immediate.Handlers.Shared.dll")]);
		csTest.TestState.ExpectedDiagnostics.AddRange(expectedDiagnostics);

		return csTest;
	}
}
