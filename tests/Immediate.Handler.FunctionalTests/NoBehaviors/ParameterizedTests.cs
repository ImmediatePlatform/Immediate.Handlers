using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Immediate.Handler.FunctionalTests.NoBehaviors;

[Handler]
public static partial class NoBehaviorParameterizedOneAdder
{
	public sealed record Query(int Input);

	private static Task<int> HandleAsync(
		Query query,
		AddendProvider addendProvider,
		CancellationToken _)
	{
		return Task.FromResult(query.Input + addendProvider.Addend);
	}
}

public class AddendProvider
{
#pragma warning disable CA1822
	public int Addend => 1;
#pragma warning restore CA1822
}

public class ParameterizedTests
{
	[Fact]
	public async Task NoBehaviorShouldReturnExpectedResponse()
	{
		const int Input = 1;

		var serviceProvider = new ServiceCollection()
			.AddHandlers()
			.AddScoped<AddendProvider>()
			.BuildServiceProvider();

		var handler = serviceProvider.GetRequiredService<NoBehaviorParameterizedOneAdder.Handler>();

		var query = new NoBehaviorParameterizedOneAdder.Query(Input);

		var result = await handler.HandleAsync(query);

		Assert.Equal(Input + serviceProvider.GetRequiredService<AddendProvider>().Addend, result);
	}
}