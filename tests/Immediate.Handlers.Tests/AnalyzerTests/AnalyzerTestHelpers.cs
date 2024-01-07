using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public static class AnalyzerTestHelpers
{
	public static CSharpAnalyzerTest<TAnalyzer, DefaultVerifier> CreateAnalyzerTest<TAnalyzer>(string inputSource, List<DiagnosticResult> expectedDiagnostics)
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
}
