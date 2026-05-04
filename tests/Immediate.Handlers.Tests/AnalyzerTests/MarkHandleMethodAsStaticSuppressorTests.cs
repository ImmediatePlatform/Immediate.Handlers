using Immediate.Handlers.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeQuality.Analyzers.QualityGuidelines;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public sealed class MarkHandleMethodAsStaticSuppressorTests
{
	public static readonly DiagnosticResult CA1822 = new("CA1822", DiagnosticSeverity.Info);

	[Fact]
	public async Task HandlerMethodCA1822IsNotSuppressedNormally() =>
		await AnalyzerTestHelpers
			.CreateSuppressorTest<MarkHandleMethodAsStaticSuppressor>(
				"""
				using System.Threading;
				using System.Threading.Tasks;
				
				namespace Immediate.Handlers.Shared;
				
				[Handler]
				public sealed partial class DoSomething
				{
					public sealed record Query;
					public sealed record Response;
				
					private ValueTask<Response> {|#0:HandleAsync|}(
						Query query,
						CancellationToken token
					)
					{
						return new();
					}
				}
				"""
			)
			.WithAnalyzer<MarkMembersAsStaticAnalyzer>()
			.WithSpecificDiagnostics([CA1822])
			.WithExpectedDiagnosticsResults([
				CA1822.WithLocation(0).WithIsSuppressed(false),
			])
			.RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task HandlerMethodCA1822IsSuppressedWithEditorConfigOption() =>
		await AnalyzerTestHelpers
			.CreateSuppressorTest<MarkHandleMethodAsStaticSuppressor>(
				"""
				using System.Threading;
				using System.Threading.Tasks;
				
				namespace Immediate.Handlers.Shared;
				
				[Handler]
				public sealed partial class DoSomething
				{
					public sealed record Query;
					public sealed record Response;
				
					private ValueTask<Response> {|#0:HandleAsync|}(
						Query query,
						CancellationToken token
					)
					{
						return new();
					}
				}
				"""
			)
			.WithAnalyzer<MarkMembersAsStaticAnalyzer>()
			.WithSpecificDiagnostics([CA1822])
			.WithExpectedDiagnosticsResults([
				CA1822.WithLocation(0).WithIsSuppressed(true),
			])
			.WithEditorConfig(
				"""
				root = true
				
				[*.cs]
				dotnet_diagnostic.IHR0019.enable_when_handler_has_no_dependencies = true
				"""
			)
			.RunAsync(TestContext.Current.CancellationToken);
}
