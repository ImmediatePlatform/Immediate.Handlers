using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.AnalyzerVerifier<
		Immediate.Handlers.Analyzers.HandlerMethodDoesNotExist>;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public class HandlerMethodDoesNotExistTests
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
}
";

		var expected = Verifier.Diagnostic()
			.WithLocation(12, 21)
			.WithArguments("GetUsersQuery");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerMethodDoesNotExist>(Text, [expected], [DriverReferenceAssemblies.Normal]);
		await test.RunAsync();
	}
}
