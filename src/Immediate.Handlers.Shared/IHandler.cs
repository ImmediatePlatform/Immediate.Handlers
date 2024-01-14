namespace Immediate.Handlers.Shared;

///  <summary>
///  Represents an abstraction implemented by the source-generated handlers
///  </summary>
///  <typeparam name="TRequest">
///    The type of the command request 
///  </typeparam>
///  <typeparam name="TResponse">
///    The type of the command response
/// </typeparam>
public interface IHandler<in TRequest, TResponse>
{
	/// <summary>
	/// The handlers entrypoint. Will invoke the logic of your defined handler, including potential behaviors
	/// </summary>
	/// <param name="request">The request payload to be handled</param>
	/// <param name="cancellationToken">Optional cancellation token passed to the handler</param>
	/// <returns>The command response returned by the inner handler</returns>
	ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
}
