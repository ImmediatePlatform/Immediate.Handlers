using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.AnalyzerVerifier<
		Immediate.Handlers.Analyzers.SampleSemanticAnalyzer>;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public class SampleSemanticAnalyzerTests
{
	[Fact]
	public async Task HandleMethodDoesNotExist_AlertDiagnostic()
	{
		const string Text = @"
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

	private static async Task<System.Collections.Generic.List<string>> HandleAsync(
		Query _,
		CancellationToken token)
	{
		return [];
	}
}
";

		var expected = Verifier.Diagnostic()
			.WithLocation(7, 28)
			.WithArguments("300000000");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<SampleSemanticAnalyzer>(Text, [expected], [DriverReferenceAssemblies.Normal]);
		await test.RunAsync();
	}
}
