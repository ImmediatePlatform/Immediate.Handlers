using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

public sealed partial class Tests
{
	[Test]
	public async Task HandlerClassNested_DoesAlert() =>
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

			public static partial class Wrapper {
				[Handler]
				public static class {|IHR0005:GetUsersQuery|}
				{
					public record Query;

					private static ValueTask<int> HandleAsync(
						Query _,
						CancellationToken token)
					{
						return ValueTask.FromResult(0);
					}
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync();
}
