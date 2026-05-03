using System.Runtime.CompilerServices;
using Immediate.Handlers.Shared;

namespace Immediate.Handlers.FunctionalTests.Streaming;

[Handler]
public static partial class StreamingNoBehaviorCounter
{
	public sealed record Query(int Count);

	private static async IAsyncEnumerable<int> Handle(
		Query query,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		for (var i = 0; i < query.Count; i++)
		{
			cancellationToken.ThrowIfCancellationRequested();
			await Task.Yield();
			yield return i;
		}
	}
}

public sealed class StreamingNoBehaviorTests
{
	[Fact]
	public async Task StreamingHandlerShouldYieldExpectedValues()
	{
		const int Count = 5;

		var handler = HandlerResolver.Resolve<StreamingNoBehaviorCounter.Handler>(services => { });

		var query = new StreamingNoBehaviorCounter.Query(Count);

		var results = new List<int>();
		await foreach (var item in handler.HandleAsync(query, TestContext.Current.CancellationToken))
			results.Add(item);

		Assert.Equal([0, 1, 2, 3, 4], results);
	}
}
