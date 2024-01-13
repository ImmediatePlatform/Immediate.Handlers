using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

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
	private Behavior<TRequest, TResponse>? _innerHandler;

	[DoesNotReturn]
	private static void ThrowException(string message) =>
		throw new InvalidOperationException(message);

	/// <summary>
	///	    The next entry in the pipeline for the current request.
	/// </summary>
	/// <remarks>
	///	    This property is called by the infrastructure, and should not be called manually.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void SetInnerHandler(Behavior<TRequest, TResponse> handler)
	{
		if (_innerHandler != null)
			ThrowException("Cannot set `_innerHandler` more than once.");
		_innerHandler = handler;
	}

	/// <summary>
	///	    Calls the next entry in the pipeline for the current request.
	/// </summary>
	/// <param name="request">
	///	    The currently processing request.
	/// </param>
	/// <param name="cancellationToken">
	///	    The optional cancellation token to be used for cancelling the operation at any time.
	/// </param>
	/// <returns>
	///	    A <see cref="Task{TResult}"/> representing a promise to return a <typeparamref name="TResponse"/> from the
	///	    next entry in the pipeline.
	/// </returns>
	protected ValueTask<TResponse> Next(TRequest request, CancellationToken cancellationToken)
	{
		if (_innerHandler == null)
			ThrowException("`_innerHandler` must be set before calling `Next()`");
		return _innerHandler.HandleAsync(request, cancellationToken);
	}

	/// <summary>
	///	    Pipeline handler. Perform any additional behavior and <c><see langword="await"/>
	///     Next(request, cancellationToken)</c>.
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
	public abstract ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken);
}
