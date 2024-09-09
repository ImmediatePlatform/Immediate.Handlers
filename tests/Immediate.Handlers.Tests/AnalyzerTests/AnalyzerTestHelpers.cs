using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Generators.ImmediateHandlers;
using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public static class AnalyzerTestHelpers
{
	public static CSharpAnalyzerTest<TAnalyzer, DefaultVerifier> CreateAnalyzerTest<TAnalyzer>(
		[StringSyntax("c#-test")] string inputSource,
		DriverReferenceAssemblies assemblies)
		where TAnalyzer : DiagnosticAnalyzer, new()
	{
		var csTest = new ImmediateHandlersGeneratorAnalyzerTest<TAnalyzer>
		{
			TestBehaviors = TestBehaviors.SkipGeneratedSourcesCheck,
			TestState =
			{
				Sources = { inputSource },
				ReferenceAssemblies = new ReferenceAssemblies(
					"net8.0",
					new PackageIdentity(
						"Microsoft.NETCore.App.Ref",
						"8.0.0"),
					Path.Combine("ref", "net8.0")
				),
			},
		};

		csTest.TestState.AdditionalReferences
			.AddRange(assemblies.GetAdditionalReferences());

		return csTest;
	}

	private sealed class ImmediateHandlersGeneratorAnalyzerTest<TAnalyzer> : CSharpAnalyzerTest<TAnalyzer, DefaultVerifier>
		where TAnalyzer : DiagnosticAnalyzer, new()
	{
		protected override IEnumerable<Type> GetSourceGenerators() =>
			[typeof(ImmediateHandlersGenerator)];
	}
}
