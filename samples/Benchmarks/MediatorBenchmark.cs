using System.Diagnostics;
using Mediator;

namespace Benchmarks;

public sealed class MediatorBehavior<TMessage, TResponse> : IPipelineBehavior<TMessage, TResponse> where TMessage : IMessage
{
	private TimeSpan _elapsed;

	public async ValueTask<TResponse> Handle(
		TMessage message,
		CancellationToken cancellationToken,
		MessageHandlerDelegate<TMessage, TResponse> next
	)
	{
#pragma warning disable CA1062
		var sw = Stopwatch.StartNew();
		var response = await next(message, cancellationToken);
		_elapsed = sw.Elapsed;
		return response;
#pragma warning restore CA1062
	}
}

public sealed record MediatorRequest(int First, int Second) : IRequest<int>;

public sealed class PingHandler : IRequestHandler<MediatorRequest, int>
{
	public ValueTask<int> Handle(MediatorRequest request, CancellationToken cancellationToken)
	{
#pragma warning disable CA1062
		return new ValueTask<int>(request.First + request.Second);
#pragma warning restore CA1062
	}
}
