using System.Diagnostics;
using Immediate.Handlers.Shared;

namespace Benchmarks;

public class ImmediateHandlersBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
{
	private TimeSpan _elapsed;
	public override async Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		var sw = Stopwatch.StartNew();
		var response = await Next(request, cancellationToken);
		_elapsed = sw.Elapsed;
		return response;
	}
}

[Handler]
[Behaviors(
	typeof(ImmediateHandlersBehavior<,>)
)]
public static partial class ImmediateHandler
{
	public record Query(int First, int Second);

	private static Task<int> HandleAsync(Query query, CancellationToken _)
	{
		return Task.FromResult(query.First + query.Second);
	}
}
