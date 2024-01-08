namespace Immediate.Handlers.Shared;

/// <summary>
///	    Allows the specification of <see cref="Behavior{TRequest, TResponse}"/>s that should be used as part of the
///     pipeline for handling a request.
/// </summary>
/// <remarks>
/// <para>
///	    If applied to the Assembly (<c>[assembly: Behavior()]</c>), then the given
///		<see cref="Behavior{TRequest, TResponse}"/>s will be part of the pipeline for all requests across the assembly.
/// </para>
/// <para>
///	    If applied to a <see cref="HandlerAttribute"/>, then the given <see cref="Behavior{TRequest, TResponse}"/>s will
///     be part of the pipeline for the request.
/// </para>
/// <para>
///	    However, any <see cref="Behavior{TRequest, TResponse}"/> that is invalid for a given type will be excluded from
///     the pipeline for that type.
/// </para>
/// </remarks>
/// <param name="types">
///	    The types for each of the <see cref="Behavior{TRequest, TResponse}"/>s that should be part of the pipeline.
/// </param>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public sealed class BehaviorsAttribute(params Type[] types) : Attribute
{
	/// <summary>
	///	    The types for each of the <see cref="Behavior{TRequest, TResponse}"/>s that should be part of the pipeline.
	/// </summary>
	public Type[] Types { get; } = types;
}
