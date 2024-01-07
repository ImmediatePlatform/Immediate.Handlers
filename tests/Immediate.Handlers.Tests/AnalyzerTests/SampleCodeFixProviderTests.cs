using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Analyzers.Diagnostics;
using Immediate.Handlers.CodeFixes;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.CodeFixVerifier<
		Immediate.Handlers.Analyzers.HandlerClassAnalyzer,
		Immediate.Handlers.CodeFixes.SampleCodeFixProvider>;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public class SampleCodeFixProviderTests
{
	[Fact]
	public async Task ShouldFix_HandlerMethodNotExisting()
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
}
";

		const string NewText = @"
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

	private static Task HandleAsync(
		Query _,
		CancellationToken token)
	{
		return Task.FromResult();
	}
}
";

		var expected = Verifier.Diagnostic(HandlerMethodMustExistDiagnostic.Rule)
			.WithLocation(12, 21)
			.WithArguments("GetUsersQuery");

		var test = AnalyzerTestHelpers.CreateCodeFixTest<HandlerClassAnalyzer, SampleCodeFixProvider>(Text, NewText, [expected]);

		await test.RunAsync();
	}
}
