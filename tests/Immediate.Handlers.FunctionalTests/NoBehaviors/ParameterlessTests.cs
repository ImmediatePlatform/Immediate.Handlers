using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

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

public class ParameterlessTests
{
	[Fact]
	public async Task NoBehaviorShouldReturnExpectedResponse()
	{
		const int Input = 1;

		var serviceProvider = new ServiceCollection()
			.AddHandlers()
			.BuildServiceProvider();

		var handler = serviceProvider.GetRequiredService<NoBehaviorParameterlessOneAdder.Handler>();

		var query = new NoBehaviorParameterlessOneAdder.Query(Input);

		var result = await handler.HandleAsync(query);

		Assert.Equal(Input + 1, result);
	}
}
