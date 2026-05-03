using Immediate.Handlers.Analyzers;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public sealed class InvalidIHandlerAnalyzerTests
{
	[Fact]
	public async Task AnalyzerTriggersForMissingImplementation() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidIHandlerAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed record Query;
			public sealed record Response;

			public static class Test
			{
				public static void Method(IHandler<Query, Response> {|IHR0013:handler|})
				{
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForPresentImplementation() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidIHandlerAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed record Query;
			public sealed record Response;

			public static class Test
			{
				public static void Method(IHandler<Query, Response> handler)
				{
				}
			}

			[Handler]
			public static partial class DummyHandler
			{
				private static ValueTask<Response> HandleAsync(
					Query _,
					CancellationToken token)
				{
					return ValueTask.FromResult(new Response());
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForGenericParameter() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidIHandlerAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public static class Test<TRequest>
			{
				public static void Method(IHandler<TRequest, int> handler)
				{
				}

				public static void Method<TResponse>(IHandler<int, TResponse> handler)
				{
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerTriggersForMissingStreamingImplementation() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidIHandlerAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed record Query;
			public sealed record Response;

			public static class Test
			{
				public static void Method(IStreamingHandler<Query, Response> {|IHR0013:handler|})
				{
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForPresentStreamingImplementation() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidIHandlerAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Runtime.CompilerServices;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed record Query;
			public sealed record Response;

			public static class Test
			{
				public static void Method(IStreamingHandler<Query, Response> handler)
				{
				}
			}

			[Handler]
			public static partial class DummyHandler
			{
				private static async IAsyncEnumerable<Response> HandleAsync(
					Query _,
					[EnumeratorCancellation] CancellationToken token)
				{
					await Task.Yield();
					yield return new Response();
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);
}
