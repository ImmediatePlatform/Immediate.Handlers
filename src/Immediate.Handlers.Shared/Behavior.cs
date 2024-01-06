namespace Immediate.Handlers.Shared;

/// <summary>
///		Represents a cross-cutting pipeline behavior
/// </summary>
/// <typeparam name="TRequest">
///		The type of a command-request
/// </typeparam>
/// <typeparam name="TResponse">
///		The type of a command-response
/// </typeparam>
public abstract class Behavior<TRequest, TResponse>
{
	/// <summary>
	///	    The next entry in the pipeline for the current request.
	/// </summary>
	/// <remarks>
	///	    This property is managed by the infrastructure, and should not be changed. It will always be present during
	///     the execution of <see cref="HandleAsync(TRequest, CancellationToken)"/>.
	/// </remarks>
	public Behavior<TRequest, TResponse> InnerHandler { get; set; } = default!;

	/// <summary>
	///	    Pipeline handler. Perform any additional behavior and <c><see langword="await"/>
	///     InnerHandler.HandleAsync(request, cancellationToken)</c>.
	/// </summary>
	/// <param name="request">
	///	    Incoming request
	/// </param>
	/// <param name="cancellationToken">
	///	    The optional cancellation token to be used for cancelling the operation at any time.
	///	</param>
	/// <returns>
	///	    A <see cref="Task{TResult}"/> representing a promise to return a <typeparamref name="TResponse"/>.
	/// </returns>
	public abstract Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken);
}
