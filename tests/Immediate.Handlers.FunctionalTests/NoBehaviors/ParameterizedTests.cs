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

public record AddendProvider(int Addend);

public sealed class ParameterizedTests
{
	[Test]
	public async Task NoBehaviorShouldReturnExpectedResponse()
	{
		const int Input = 1;
		var addendProvider = new AddendProvider(1);

		var handler = HandlerResolver.Resolve<NoBehaviorParameterizedOneAdder.Handler>(x => x.AddScoped(_ => addendProvider));

		var query = new NoBehaviorParameterizedOneAdder.Query(Input);

		var result = await handler.HandleAsync(query);

		Assert.Equal(Input + addendProvider.Addend, result);
	}
}
