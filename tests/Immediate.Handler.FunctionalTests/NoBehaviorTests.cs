using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Immediate.Handler.FunctionalTests;

[Handler]
public static partial class OneAdder
{
	public sealed record Query(int Input);

	private static Task<int> HandleAsync(
		Query query,
		CancellationToken _)
	{
		return Task.FromResult(query.Input + 1);
	}
}

public class NoBehaviorTests
{
	[Fact]
	public async Task NoBehaviorShouldReturnExpectedResponse()
	{
		var serviceProvider = new ServiceCollection()
			.AddHandlers()
			.BuildServiceProvider();

		var handler = serviceProvider.GetRequiredService<OneAdder.Handler>();

		var query = new OneAdder.Query(1);

		var result = await handler.HandleAsync(query);

		Assert.Equal(query.Input + 1, result);
	}
}
