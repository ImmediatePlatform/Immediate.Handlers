using Immediate.Handlers.Shared;
using Normal;

[assembly: Behaviors(
	typeof(LoggingBehavior<,>)
)]

namespace Normal;

public sealed class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
	: Behavior<TRequest, TResponse>
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		_ = logger.ToString();
		var response = await Next(request, cancellationToken);

		return response;
	}
}
