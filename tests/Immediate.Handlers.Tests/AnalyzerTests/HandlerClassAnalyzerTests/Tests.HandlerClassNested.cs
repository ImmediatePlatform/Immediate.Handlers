using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.AnalyzerVerifier<
		Immediate.Handlers.Analyzers.HandlerClassAnalyzer>;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

public partial class Tests
{
	[Fact]
	public async Task HandlerClassNested_DoesAlert()
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

public class Wrapper {
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
}
""";
		var expectedDiagnostic = Verifier.Diagnostic(DiagnosticIds.IHR0005HandlerClassMustNotBeNested)
			.WithLocation(12, 22)
			.WithArguments("GetUsersQuery");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			Text,
			DriverReferenceAssemblies.Normal,
			[expectedDiagnostic]
		);
		await test.RunAsync();
	}
}
