using Immediate.Handlers.Shared;
using Xunit;

namespace Immediate.Handlers.FunctionalTests.MultipleBehaviors;

public class Behavior1<TRequest, TResponse> : Behavior<TRequest, TResponse>
	where TRequest : List<string>
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		ArgumentNullException.ThrowIfNull(request);

		request.Add("Behavior1.Enter");
		var response = await Next(request, cancellationToken);
		request.Add("Behavior1.Exit");

		return response;
	}
}

public class Behavior2<TRequest, TResponse> : Behavior<TRequest, TResponse>
	where TRequest : List<string>
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		ArgumentNullException.ThrowIfNull(request);

		request.Add("Behavior2.Enter");
		var response = await Next(request, cancellationToken);
		request.Add("Behavior2.Exit");

		return response;
	}
}

[Handler]
[Behaviors(
	typeof(Behavior1<,>),
	typeof(Behavior2<,>)
)]
public static partial class MultipleBehaviorHandler
{
	public class Query : List<string>;

	private static async ValueTask<int> HandleAsync(Query query, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		query.Add("Query.HandleAsync");
		await Task.Yield();
		return 3;
	}
}

public sealed class MultipleBehaviorsTests
{
	[Fact]
	public async Task TestBehaviorOrdering()
	{
		var query = new MultipleBehaviorHandler.Query();
		var handler = new MultipleBehaviorHandler.Handler(
			new(), new(), new());

		_ = await handler.HandleAsync(query);

		Assert.Equal(
			[
				"Behavior1.Enter",
				"Behavior2.Enter",
				"Query.HandleAsync",
				"Behavior2.Exit",
				"Behavior1.Exit",
			],
			query);
	}
}
