using System.Runtime.CompilerServices;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.FunctionalTests.NoBehaviors;

[Handler]
public static partial class NoBehaviorParameterizedOneAdder
{
	public sealed record Query(int Input);

	private static ValueTask<int> Handle(
		Query query,
		AddendProvider addendProvider,
		CancellationToken _)
	{
		return ValueTask.FromResult(query.Input + addendProvider.Addend);
	}
}

public sealed record AddendProvider(int Addend);

public sealed class ParameterizedTests
{
	[Fact]
	public async Task NoBehaviorShouldReturnExpectedResponse()
	{
		const int Input = 1;
		var addendProvider = new AddendProvider(1);

		var handler = HandlerResolver.Resolve<NoBehaviorParameterizedOneAdder.Handler>(x => x.AddScoped(_ => addendProvider));

		var query = new NoBehaviorParameterizedOneAdder.Query(Input);

		var result = await handler.HandleAsync(query, TestContext.Current.CancellationToken);

		Assert.Equal(Input + addendProvider.Addend, result);
	}
}

[Handler]
public static partial class StreamingNoBehaviorParameterizedCounter
{
	public sealed record Query(int Count);

	private static async IAsyncEnumerable<int> Handle(
		Query query,
		AddendProvider addendProvider,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		for (var i = 0; i < query.Count; i++)
		{
			cancellationToken.ThrowIfCancellationRequested();
			await Task.Yield();
			yield return i + addendProvider.Addend;
		}
	}
}

public sealed class StreamingParameterizedTests
{
	[Fact]
	public async Task StreamingNoBehaviorShouldYieldExpectedValues()
	{
		const int Count = 5;
		var addendProvider = new AddendProvider(10);

		var handler = HandlerResolver.Resolve<StreamingNoBehaviorParameterizedCounter.Handler>(x => x.AddScoped(_ => addendProvider));

		var query = new StreamingNoBehaviorParameterizedCounter.Query(Count);

		var results = new List<int>();
		await foreach (var item in handler.HandleAsync(query, TestContext.Current.CancellationToken))
			results.Add(item);

		Assert.Equal([10, 11, 12, 13, 14], results);
	}
}
