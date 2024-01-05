namespace Immediate.Handlers.Shared;

/// <summary>
/// TODO: Fill out
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public abstract class Behavior<TRequest, TResponse>
{
	/// <summary>
	/// TODO: Fill out
	/// </summary>
	public Behavior<TRequest, TResponse> InnerHandler { get; set; } = default!;

	/// <summary>
	/// TODO: Fill out
	/// </summary>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public abstract Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken);
}
