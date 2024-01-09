using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

public partial class Tests
{
	[Fact]
	public async Task HandlerClassNested_DoesAlert()
	{
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

			public class Wrapper {
				[Handler]
				public static class {|IHR0005:GetUsersQuery|}
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
			""",
			DriverReferenceAssemblies.Normal,
			[]
		).RunAsync();
	}
}
