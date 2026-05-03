using Immediate.Handlers.Analyzers;

namespace Immediate.Handlers.Tests.AnalyzerTests.BehaviorAnalyzerTests;

public sealed partial class Tests
{
	[Fact]
	public async Task StreamingBehaviorTypeIsValid_DoesNotAlert() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsAnalyzer>(
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
			using Normal;

			[assembly: Behaviors(
				typeof(LoggingStreamingBehavior<,>)
			)]

			namespace Normal;

			public interface ILogger<T>;

			public class LoggingStreamingBehavior<TRequest, TResponse>(ILogger<LoggingStreamingBehavior<TRequest, TResponse>> logger)
				: Immediate.Handlers.Shared.StreamingBehavior<TRequest, TResponse>
			{
				public override async IAsyncEnumerable<TResponse> HandleAsync(
					TRequest request,
					[EnumeratorCancellation] CancellationToken cancellationToken)
				{
					_ = logger.ToString();
					await foreach (var item in Next(request, cancellationToken))
						yield return item;
				}
			}

			[Handler]
			[Behaviors(
				typeof(LoggingStreamingBehavior<,>)
			)]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static async IAsyncEnumerable<int> HandleAsync(
					Query _,
					[EnumeratorCancellation] CancellationToken token)
				{
					await Task.Yield();
					yield return 0;
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);
}
