using System.Runtime.CompilerServices;
using Immediate.Handlers.Shared;

namespace Immediate.Handlers.FunctionalTests.HandlerAbstraction;

public sealed record HandlerAbstractionOneAdderQuery(int Input);

[Handler]
public static partial class HandlerAbstractionOneAdder
{
	private static ValueTask<int> HandleAsync(
		HandlerAbstractionOneAdderQuery handlerAbstractionOneAdderQuery,
		CancellationToken _)
	{
		return ValueTask.FromResult(handlerAbstractionOneAdderQuery.Input + 1);
	}
}

public sealed record StreamingHandlerAbstractionCounterQuery(int Count);

[Handler]
public static partial class StreamingHandlerAbstractionCounter
{
	private static async IAsyncEnumerable<int> HandleAsync(
		StreamingHandlerAbstractionCounterQuery query,
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

public sealed class HandlerAbstractionTests
{
	[Fact]
	public async Task NoBehaviorShouldReturnExpectedResponseForAbstraction()
	{
		const int Input = 1;

		var handler = HandlerResolver.Resolve<IHandler<HandlerAbstractionOneAdderQuery, int>>();

		var query = new HandlerAbstractionOneAdderQuery(Input);

		var result = await handler.HandleAsync(query, TestContext.Current.CancellationToken);

		Assert.Equal(Input + 1, result);
	}

	[Fact]
	public async Task StreamingNoBehaviorShouldYieldExpectedValuesForAbstraction()
	{
		const int Count = 5;

		var handler = HandlerResolver.Resolve<IStreamingHandler<StreamingHandlerAbstractionCounterQuery, int>>();

		var query = new StreamingHandlerAbstractionCounterQuery(Count);

		var results = new List<int>();
		await foreach (var item in handler.HandleAsync(query, TestContext.Current.CancellationToken))
			results.Add(item);

		Assert.Equal([0, 1, 2, 3, 4], results);
	}
}
