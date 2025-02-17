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

public sealed class HandlerAbstractionTests
{
	[Test]
	public async Task NoBehaviorShouldReturnExpectedResponseForAbstraction()
	{
		const int Input = 1;

		var handler = HandlerResolver.Resolve<IHandler<HandlerAbstractionOneAdderQuery, int>>();

		var query = new HandlerAbstractionOneAdderQuery(Input);

		var result = await handler.HandleAsync(query);

		Assert.Equal(Input + 1, result);
	}
}
