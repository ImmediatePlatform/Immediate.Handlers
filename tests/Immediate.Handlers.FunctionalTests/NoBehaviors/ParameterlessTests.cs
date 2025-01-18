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

	private static ValueTask<int> HandleAsync(
		Query query
	)
	{
		return ValueTask.FromResult(query.Input + 1);
	}
}

public sealed class ParameterlessTests
{
	[Test]
	public async Task NoBehaviorShouldReturnExpectedResponse()
	{
		const int Input = 1;

		var handler = HandlerResolver.Resolve<NoBehaviorParameterlessOneAdder.Handler>();

		var query = new NoBehaviorParameterlessOneAdder.Query(Input);

		var result = await handler.HandleAsync(query);

		Assert.Equal(Input + 1, result);
	}

	[Test]
	public async Task NoTokenShouldReturnExpectedResponse()
	{
		const int Input = 1;

		var handler = HandlerResolver.Resolve<NoBehaviorNoTokenOneAdder.Handler>();

		var query = new NoBehaviorNoTokenOneAdder.Query(Input);

		var result = await handler.HandleAsync(query);

		Assert.Equal(Input + 1, result);
	}
}
