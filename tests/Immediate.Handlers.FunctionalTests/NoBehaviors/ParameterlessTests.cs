using System.Runtime.CompilerServices;
using Immediate.Handlers.Shared;

namespace Immediate.Handlers.FunctionalTests.NoBehaviors;

[Handler]
public static partial class NoBehaviorParameterlessOneAdder
{
	public sealed record Query(int Input);

	private static ValueTask<int> HandleAsync(
		Query query,
		CancellationToken _)
	{
		return ValueTask.FromResult(query.Input + 1);
	}
}

[Handler]
public static partial class NoBehaviorNoTokenOneAdder
{
	public sealed record Query(int Input);

	private static ValueTask<int> HandleAsync(Query query, CancellationToken _)
	{
		return ValueTask.FromResult(query.Input + 1);
	}
}

public sealed class ParameterlessTests
{
	[Fact]
	public async Task NoBehaviorShouldReturnExpectedResponse()
	{
		const int Input = 1;

		var handler = HandlerResolver.Resolve<NoBehaviorParameterlessOneAdder.Handler>();

		var query = new NoBehaviorParameterlessOneAdder.Query(Input);

		var result = await handler.HandleAsync(query, TestContext.Current.CancellationToken);

		Assert.Equal(Input + 1, result);
	}

	[Fact]
	public async Task NoTokenShouldReturnExpectedResponse()
	{
		const int Input = 1;

		var handler = HandlerResolver.Resolve<NoBehaviorNoTokenOneAdder.Handler>();

		var query = new NoBehaviorNoTokenOneAdder.Query(Input);

		var result = await handler.HandleAsync(query, TestContext.Current.CancellationToken);

		Assert.Equal(Input + 1, result);
	}
}

[Handler]
public static partial class StreamingNoBehaviorParameterlessCounter
{
	public sealed record Query(int Count);

	private static async IAsyncEnumerable<int> HandleAsync(
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

[Handler]
public static partial class StreamingNoBehaviorNoTokenCounter
{
	public sealed record Query(int Count);

	private static async IAsyncEnumerable<int> HandleAsync(
		Query query,
		[EnumeratorCancellation] CancellationToken _)
	{
		for (var i = 0; i < query.Count; i++)
		{
			await Task.Yield();
			yield return i;
		}
	}
}

public sealed class StreamingParameterlessTests
{
	[Fact]
	public async Task StreamingNoBehaviorShouldYieldExpectedValues()
	{
		const int Count = 5;

		var handler = HandlerResolver.Resolve<StreamingNoBehaviorParameterlessCounter.Handler>();

		var query = new StreamingNoBehaviorParameterlessCounter.Query(Count);

		var results = new List<int>();
		await foreach (var item in handler.HandleAsync(query, TestContext.Current.CancellationToken))
			results.Add(item);

		Assert.Equal([0, 1, 2, 3, 4], results);
	}

	[Fact]
	public async Task StreamingNoTokenShouldYieldExpectedValues()
	{
		const int Count = 5;

		var handler = HandlerResolver.Resolve<StreamingNoBehaviorNoTokenCounter.Handler>();

		var query = new StreamingNoBehaviorNoTokenCounter.Query(Count);

		var results = new List<int>();
		await foreach (var item in handler.HandleAsync(query, TestContext.Current.CancellationToken))
			results.Add(item);

		Assert.Equal([0, 1, 2, 3, 4], results);
	}
}
