using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Immediate.Handlers.Shared;

/// <summary>
///		Represents a cross-cutting pipeline behavior for streaming handlers
/// </summary>
/// <typeparam name="TRequest">
///		The type of a command-request
/// </typeparam>
/// <typeparam name="TResponse">
///		The type of each streamed response element
/// </typeparam>
public abstract class StreamingBehavior<TRequest, TResponse>
{
	/// <summary>
	///		The <see cref="Type"/> of the Handler class for the current request.
	/// </summary>
	public Type HandlerType { get; [EditorBrowsable(EditorBrowsableState.Never)] set; } = default!;

	private StreamingBehavior<TRequest, TResponse>? _innerHandler;

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
	public void SetInnerHandler(StreamingBehavior<TRequest, TResponse> handler)
	{
		if (_innerHandler != null)
			ThrowException("Cannot set `_innerHandler` more than once.");
		_innerHandler = handler;
	}

	/// <summary>
	///	    Calls the next entry in the pipeline for the current streaming request.
	/// </summary>
	/// <param name="request">
	///	    The currently processing request.
	/// </param>
	/// <param name="cancellationToken">
	///	    The optional cancellation token to be used for cancelling the operation at any time.
	/// </param>
	/// <returns>
	///	    An <see cref="IAsyncEnumerable{TResponse}"/> from the next entry in the pipeline.
	/// </returns>
	protected IAsyncEnumerable<TResponse> Next(TRequest request, CancellationToken cancellationToken)
	{
		if (_innerHandler == null)
			ThrowException("`_innerHandler` must be set before calling `Next()`");
		return _innerHandler.HandleAsync(request, cancellationToken);
	}

	/// <summary>
	///	    Pipeline handler. Perform any additional behavior and iterate over
	///     <c>Next(request, cancellationToken)</c> using <c><see langword="await"/> foreach</c>.
	/// </summary>
	/// <param name="request">
	///	    Incoming request
	/// </param>
	/// <param name="cancellationToken">
	///	    The optional cancellation token to be used for cancelling the operation at any time.
	///	</param>
	/// <returns>
	///	    An <see cref="IAsyncEnumerable{TResponse}"/> of <typeparamref name="TResponse"/> elements.
	/// </returns>
	public abstract IAsyncEnumerable<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken);
}
