namespace Immediate.Handlers.Shared;

/// <summary>
///		Represents an abstraction implemented by the source-generated streaming handlers
/// </summary>
/// <typeparam name="TRequest">
///		The type of the command request 
/// </typeparam>
/// <typeparam name="TResponse">
///		The type of the streamed response element
/// </typeparam>
public interface IStreamingHandler<TRequest, TResponse>
{
	/// <summary>
	///		The streaming handler's entrypoint. Will invoke the logic of your defined handler, including potential behaviors
	/// </summary>
	/// <param name="request">
	///		The request payload to be handled
	/// </param>
	/// <param name="cancellationToken">
	///		Optional cancellation token passed to the handler
	/// </param>
	/// <returns>
	///		An <see cref="IAsyncEnumerable{TResponse}"/> returned by the inner handler
	/// </returns>
	IAsyncEnumerable<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
}
