namespace Immediate.Handlers.Shared;

/// <summary>
///		Specifies which type of handler should be rendered
/// </summary>
public enum RenderMode
{
	/// <summary>
	///		Represents an invalid entry, and should not be used.
	/// </summary>
	None,

	/// <summary>
	///		A common handler should be rendered.
	/// </summary>
	Normal,
}

/// <summary>
///	    Allows the specification of which type of handler should be rendered.
/// </summary>
///	<remarks>
///	<para>
///	    If applied to the Assembly (<c>[assembly: RenderMode()]</c>), then all handlers will use the given <see
///	    cref="Shared.RenderMode"/> unless overriden.
///	</para>
///	<para>
///	    If applied to a <see cref="HandlerAttribute"/>, then the specified handler will be rendered.
///	</para>
///	</remarks>
/// <param name="renderMode">
///	    Which type of handler should be rendered
/// </param>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public sealed class RenderModeAttribute(RenderMode renderMode) : Attribute
{
	/// <summary>
	///		Which type of handler should be rendered
	/// </summary>
	public RenderMode RenderMode { get; } = renderMode;
}
