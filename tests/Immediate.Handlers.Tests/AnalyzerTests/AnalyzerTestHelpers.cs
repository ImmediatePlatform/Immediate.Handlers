using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public static class AnalyzerTestHelpers
{
	public static CSharpAnalyzerTest<TAnalyzer, DefaultVerifier> CreateAnalyzerTest<TAnalyzer>(
		string inputSource,
		DriverReferenceAssemblies assemblies,
		IEnumerable<DiagnosticResult> expectedDiagnostics
	)
		where TAnalyzer : DiagnosticAnalyzer, new()
	{
		var csTest = new CSharpAnalyzerTest<TAnalyzer, DefaultVerifier>
		{
			TestState =
			{
				Sources = { inputSource },
			},
		};

		csTest.TestState.AdditionalReferences
			.AddRange(assemblies.GetAdditionalReferences());

		csTest.TestState.ExpectedDiagnostics
			.AddRange(expectedDiagnostics);

		return csTest;
	}
}
