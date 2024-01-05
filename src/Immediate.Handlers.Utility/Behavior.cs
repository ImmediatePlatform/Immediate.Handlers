namespace Immediate.Handlers.Utility;

/// <summary>
/// TODO: Fill out
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public class Behavior<TRequest, TResponse>
{
	/// <summary>
	/// TODO: Fill out
	/// </summary>
	public Behavior<TRequest, TResponse> InnerHandler { get; set; } = default!;
}
