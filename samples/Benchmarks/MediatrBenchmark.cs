using System.Diagnostics;
using MediatR;
using IRequest = MediatR.IRequest;

namespace Immediate.Handlers.Benchmarks;

public sealed class MediatrBehavior<TMessage, TResponse> : IPipelineBehavior<TMessage, TResponse> where TMessage : IRequest
{
	private TimeSpan _elapsed;
	public async Task<TResponse> Handle(TMessage request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
	{
#pragma warning disable CA1062
		var sw = Stopwatch.StartNew();
		var response = await next();
		_elapsed = sw.Elapsed;
		return response;
#pragma warning restore CA1062
	}
}

public sealed record MediatrRequest(int First, int Second) : IRequest<int>;

public sealed class MediatrHandler : IRequestHandler<MediatrRequest, int>
{
	public Task<int> Handle(MediatrRequest request, CancellationToken cancellationToken)
	{
#pragma warning disable CA1062
		return Task.FromResult(request.First + request.Second);
#pragma warning restore CA1062
	}
}
