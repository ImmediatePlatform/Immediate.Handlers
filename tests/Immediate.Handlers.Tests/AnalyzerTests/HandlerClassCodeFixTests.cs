using Immediate.Handlers.Analyzers;
using Immediate.Handlers.CodeFixes;
using Verifier = Microsoft.CodeAnalysis.CSharp.Testing.XUnit.CodeFixVerifier<
	Immediate.Handlers.Analyzers.HandlerClassAnalyzer,
	Immediate.Handlers.CodeFixes.HandlerClassCodeFixProvider>;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public class HandlerClassCodeFixTests
{
	[Fact]
	public async Task CodeFixTest()
	{
		var input = @"
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
}";
		var fixedSource = @"
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
		return null;
	}
}
";

		var test = AnalyzerTestHelpers.CreateCodeFixTest<HandlerClassAnalyzer, HandlerClassCodeFixProvider>(input, fixedSource, [Verifier.Diagnostic("IH0001")]);

		await test.RunAsync();
	}
}
