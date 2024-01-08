using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Fact]
	public async Task HandleMethodIsCorrect_DoesNotAlert()
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

[Handler]
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

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			Text,
			DriverReferenceAssemblies.Normal,
			[]
		);
		await test.RunAsync();
	}
}