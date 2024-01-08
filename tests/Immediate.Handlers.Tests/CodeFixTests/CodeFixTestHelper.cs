using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.CodeFixTests;

public static class CodeFixTestHelper
{
	public static CSharpCodeFixTest<TAnalyzer, TCodeFix, DefaultVerifier> CreateCodeFixTest<TAnalyzer, TCodeFix>(
		string inputSource,
		string fixedSource,
		DriverReferenceAssemblies assemblies,
		IEnumerable<DiagnosticResult> expectedDiagnostics,
		IEnumerable<DiagnosticResult> expectedFixedDiagnostics)
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

		csTest.TestState.AdditionalReferences
			.AddRange(assemblies.GetAdditionalReferences());

		csTest.TestState.ExpectedDiagnostics
			.AddRange(expectedDiagnostics);

		csTest.FixedState.ExpectedDiagnostics
			.AddRange(expectedFixedDiagnostics);

		return csTest;
	}

}
