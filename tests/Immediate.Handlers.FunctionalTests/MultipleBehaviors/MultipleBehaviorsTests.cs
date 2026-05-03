using System.Runtime.CompilerServices;
using Immediate.Handlers.Shared;

namespace Immediate.Handlers.FunctionalTests.MultipleBehaviors;

public sealed class Behavior1<TRequest, TResponse> : Behavior<TRequest, TResponse>
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

public sealed class Behavior2<TRequest, TResponse> : Behavior<TRequest, TResponse>
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
	typeof(Behavior2<,>),
	typeof(Behavior1<,>)
)]
public static partial class MultipleBehaviorHandler
{
	public sealed class Query : List<string>;

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
			new(), new(), new(), new());

		_ = await handler.HandleAsync(query, TestContext.Current.CancellationToken);

		Assert.Equal(
			[
				"Behavior1.Enter",
				"Behavior2.Enter",
				"Behavior1.Enter",
				"Query.HandleAsync",
				"Behavior1.Exit",
				"Behavior2.Exit",
				"Behavior1.Exit",
			],
			query
		);
	}
}

public sealed class StreamingBehavior1<TRequest, TResponse> : StreamingBehavior<TRequest, TResponse>
	where TRequest : List<string>
{
	public override async IAsyncEnumerable<TResponse> HandleAsync(
		TRequest request,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		ArgumentNullException.ThrowIfNull(request);

		request.Add("StreamingBehavior1.Enter");
		await foreach (var item in Next(request, cancellationToken))
			yield return item;
		request.Add("StreamingBehavior1.Exit");
	}
}

public sealed class StreamingBehavior2<TRequest, TResponse> : StreamingBehavior<TRequest, TResponse>
	where TRequest : List<string>
{
	public override async IAsyncEnumerable<TResponse> HandleAsync(
		TRequest request,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		ArgumentNullException.ThrowIfNull(request);

		request.Add("StreamingBehavior2.Enter");
		await foreach (var item in Next(request, cancellationToken))
			yield return item;
		request.Add("StreamingBehavior2.Exit");
	}
}

[Handler]
[Behaviors(
	typeof(StreamingBehavior1<,>),
	typeof(StreamingBehavior2<,>),
	typeof(StreamingBehavior1<,>)
)]
public static partial class MultipleStreamingBehaviorsHandler
{
	public sealed class Query : List<string>;

	private static async IAsyncEnumerable<int> HandleAsync(
		Query query,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		query.Add("Query.HandleAsync");
		await Task.Yield();
		yield return 3;
	}
}

public sealed class MultipleStreamingBehaviorsTests
{
	[Fact]
	public async Task TestStreamingBehaviorOrdering()
	{
		var query = new MultipleStreamingBehaviorsHandler.Query();
		var handler = new MultipleStreamingBehaviorsHandler.Handler(
			new(), new(), new(), new());

		var results = new List<int>();
		await foreach (var item in handler.HandleAsync(query, TestContext.Current.CancellationToken))
			results.Add(item);

		Assert.Equal([3], results);
		Assert.Equal(
			[
				"StreamingBehavior1.Enter",
				"StreamingBehavior2.Enter",
				"StreamingBehavior1.Enter",
				"Query.HandleAsync",
				"StreamingBehavior1.Exit",
				"StreamingBehavior2.Exit",
				"StreamingBehavior1.Exit",
			],
			query
		);
	}
}
