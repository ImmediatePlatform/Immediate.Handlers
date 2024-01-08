using Immediate.Handlers.Analyzers;
using Immediate.Handlers.CodeFixes;
using Immediate.Handlers.Tests.Helpers;
using Verifier = Microsoft.CodeAnalysis.CSharp.Testing.XUnit.CodeFixVerifier<
	Immediate.Handlers.Analyzers.HandlerClassAnalyzer,
	Immediate.Handlers.CodeFixes.HandlerClassCodeFixProvider>;

namespace Immediate.Handlers.Tests.CodeFixTests.HandlerClassCodeFixTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public class Tests
{
	[Fact]
	public async Task HandleMethodDoesNotExist()
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

	private static Task<int> HandleAsync(Query _, CancellationToken token)
	{
		return null;
	}
}";

		var expected = Verifier.Diagnostic("IH0001")
			.WithLocation(12, 21)
			.WithArguments("GetUsersQuery");

		//var expectedFixed = DiagnosticResult.CompilerError("CS7003").WithSpan(15, 17, 15, 23);

		var test = CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerClassCodeFixProvider>(input, fixedSource, DriverReferenceAssemblies.Normal, [expected], []);

		await test.RunAsync();
	}
}
