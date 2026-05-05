using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Generators;
using Microsoft.CodeAnalysis;
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
				ReferenceAssemblies = Utility.ReferenceAssemblies,
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

	public sealed class CSharpSuppressorTest<TSuppressor, TVerifier> : CSharpAnalyzerTest<TSuppressor, TVerifier>
	where TSuppressor : DiagnosticSuppressor, new()
	where TVerifier : IVerifier, new()
	{
		private readonly List<DiagnosticAnalyzer> _analyzers = [];

		protected override IEnumerable<DiagnosticAnalyzer> GetDiagnosticAnalyzers() =>
			base.GetDiagnosticAnalyzers().Concat(_analyzers);

		public CSharpSuppressorTest<TSuppressor, TVerifier> WithAnalyzer<TAnalyzer>(bool enableDiagnostics = false)
			where TAnalyzer : DiagnosticAnalyzer, new()
		{
			var analyzer = new TAnalyzer();
			_analyzers.Add(analyzer);

			if (enableDiagnostics)
			{
				var diagnosticOptions = analyzer.SupportedDiagnostics
					.ToImmutableDictionary(
						descriptor => descriptor.Id,
						descriptor => descriptor.DefaultSeverity.ToReportDiagnostic()
					);

				SolutionTransforms.Clear();
				SolutionTransforms.Add(EnableDiagnostics(diagnosticOptions));
			}

			return this;
		}

		public CSharpSuppressorTest<TSuppressor, TVerifier> WithSpecificDiagnostics(
			params DiagnosticResult[] diagnostics
		)
		{
			var diagnosticOptions = diagnostics
				.ToImmutableDictionary(
					descriptor => descriptor.Id,
					descriptor => descriptor.Severity.ToReportDiagnostic()
				);

			SolutionTransforms.Clear();
			SolutionTransforms.Add(EnableDiagnostics(diagnosticOptions));
			return this;
		}

		private static Func<Solution, ProjectId, Solution> EnableDiagnostics(
			ImmutableDictionary<string, ReportDiagnostic> diagnostics
		) =>
			(solution, id) =>
			{
				var options = solution.GetProject(id)?.CompilationOptions
					?? throw new InvalidOperationException("Compilation options missing.");

				return solution
					.WithProjectCompilationOptions(
						id,
						options
							.WithSpecificDiagnosticOptions(diagnostics)
					);
			};

		public CSharpSuppressorTest<TSuppressor, TVerifier> WithExpectedDiagnosticsResults(
			params DiagnosticResult[] diagnostics
		)
		{
			ExpectedDiagnostics.AddRange(diagnostics);
			return this;
		}

		public CSharpSuppressorTest<TSuppressor, TVerifier> WithEditorConfig(
			string content
		)
		{
			TestState.AnalyzerConfigFiles.Add(("/.editorconfig", content));
			return this;
		}
	}

	public static CSharpSuppressorTest<TSuppressor, DefaultVerifier> CreateSuppressorTest<TSuppressor>(
		[StringSyntax("c#-test")] string inputSource
	)
		where TSuppressor : DiagnosticSuppressor, new()
	{
		var test = new CSharpSuppressorTest<TSuppressor, DefaultVerifier>
		{
			TestCode = inputSource,
			ReferenceAssemblies = Utility.ReferenceAssemblies,
			CompilerDiagnostics = CompilerDiagnostics.Warnings,
			DisabledDiagnostics =
			{
				"CS1591",
				"CS8767",
			},
		};

		test.TestState.AdditionalReferences
			.AddRange(DriverReferenceAssemblies.Normal.GetAdditionalReferences());

		return test;
	}
}

file static class DiagnosticSeverityExtensions
{
	public static ReportDiagnostic ToReportDiagnostic(this DiagnosticSeverity severity)
		=> severity switch
		{
			DiagnosticSeverity.Hidden => ReportDiagnostic.Hidden,
			DiagnosticSeverity.Info => ReportDiagnostic.Info,
			DiagnosticSeverity.Warning => ReportDiagnostic.Warn,
			DiagnosticSeverity.Error => ReportDiagnostic.Error,
			_ => throw new InvalidEnumArgumentException(nameof(severity), (int)severity, typeof(DiagnosticSeverity)),
		};
}
