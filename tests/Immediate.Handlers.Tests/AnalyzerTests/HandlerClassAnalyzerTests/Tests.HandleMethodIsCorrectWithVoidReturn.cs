using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Fact]
	public async Task HandleMethodIsCorrectWithVoidReturn_DoesNotAlert() =>
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
			public partial class GetUsersQuery
			{
				public record Query;

				private static async ValueTask HandleAsync(
					Query _,
					CancellationToken token)
				{
				}
			
				private async ValueTask Handle(
					Query _,
					CancellationToken token)
				{
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync();
}
