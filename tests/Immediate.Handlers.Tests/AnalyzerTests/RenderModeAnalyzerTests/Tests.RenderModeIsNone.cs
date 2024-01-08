using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.AnalyzerVerifier<
		Immediate.Handlers.Analyzers.RenderModeAnalyzer>;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Fact]
	public async Task RenderModeIsNone_Alerts()
	{
		const string Text = """
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Immediate.Handlers.Shared;

[assembly: RenderMode(RenderMode.None)]

[Handler]
[RenderMode(RenderMode.None)]
public static class GetUsersQuery
{
	public record Query;

	private static Task<int> HandleAsync(
		Query _,
		CancellationToken token)
	{
		return Task.FromResult(0);
	}
}
""";

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<RenderModeAnalyzer>(
			Text,
			DriverReferenceAssemblies.Normal,
			[
				Verifier.Diagnostic("IHR0004").WithLocation(10, 12),
				Verifier.Diagnostic("IHR0004").WithLocation(13, 2),
			]
		);
		await test.RunAsync();
	}
}
