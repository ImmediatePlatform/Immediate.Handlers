using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Test]
	public async Task HandleMethodWithoutCancellationToken_AlertDiagnostic() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;
			
				private static ValueTask<int> {|IHR0012:HandleAsync|}(
					Query _)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync();
}
