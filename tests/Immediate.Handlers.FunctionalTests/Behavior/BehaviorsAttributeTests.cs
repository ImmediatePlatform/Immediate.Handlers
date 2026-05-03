using System.Runtime.CompilerServices;
using Immediate.Handlers.Shared;

namespace Immediate.Handlers.FunctionalTests.Behavior;

// Non-streaming: behavior applied via a custom attribute decorated with [Behaviors]
[AttributeUsage(AttributeTargets.Class)]
[Behaviors(typeof(AttributeTestBehavior<,>))]
public sealed class DefaultBehaviorsAttribute : Attribute;

public sealed class AttributeTestBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
	where TRequest : List<string>
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		ArgumentNullException.ThrowIfNull(request);

		request.Add("AttributeTestBehavior.Called");
		return await Next(request, cancellationToken);
	}
}

[Handler]
[DefaultBehaviors]
public static partial class AttributeBehaviorsHandler
{
	public sealed class Query : List<string>;

	private static ValueTask<int> HandleAsync(Query query, CancellationToken _)
	{
		query.Add("Handler.Called");
		return ValueTask.FromResult(42);
	}
}

// Streaming: streaming behavior applied via a custom attribute decorated with [Behaviors]
[AttributeUsage(AttributeTargets.Class)]
[Behaviors(typeof(StreamingAttributeTestBehavior<,>))]
public sealed class DefaultStreamingBehaviorsAttribute : Attribute;

public sealed class StreamingAttributeTestBehavior<TRequest, TResponse> : StreamingBehavior<TRequest, TResponse>
	where TRequest : List<string>
{
	public override async IAsyncEnumerable<TResponse> HandleAsync(
		TRequest request,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		ArgumentNullException.ThrowIfNull(request);

		request.Add("StreamingAttributeTestBehavior.Enter");
		await foreach (var item in Next(request, cancellationToken))
			yield return item;
		request.Add("StreamingAttributeTestBehavior.Exit");
	}
}

[Handler]
[DefaultStreamingBehaviors]
public static partial class StreamingAttributeBehaviorsHandler
{
	public sealed class Query : List<string>;

	private static async IAsyncEnumerable<int> HandleAsync(
		Query query,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		query.Add("Handler.Called");
		await Task.Yield();
		yield return 42;
	}
}

public sealed class BehaviorsAttributeTests
{
	[Fact]
	public async Task BehaviorsAppliedViaCustomAttributeToHandler()
	{
		var query = new AttributeBehaviorsHandler.Query();
		var handler = new AttributeBehaviorsHandler.Handler(new(), new());

		_ = await handler.HandleAsync(query, TestContext.Current.CancellationToken);

		Assert.Equal(
			["AttributeTestBehavior.Called", "Handler.Called"],
			query
		);
	}

	[Fact]
	public async Task StreamingBehaviorsAppliedViaCustomAttributeToHandler()
	{
		var query = new StreamingAttributeBehaviorsHandler.Query();
		var handler = new StreamingAttributeBehaviorsHandler.Handler(new(), new());

		var results = new List<int>();
		await foreach (var item in handler.HandleAsync(query, TestContext.Current.CancellationToken))
			results.Add(item);

		Assert.Equal([42], results);
		Assert.Equal(
			[
				"StreamingAttributeTestBehavior.Enter",
				"Handler.Called",
				"StreamingAttributeTestBehavior.Exit",
			],
			query
		);
	}
}
