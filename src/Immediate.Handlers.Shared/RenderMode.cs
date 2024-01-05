namespace Immediate.Handlers.Shared;

/// <summary>
/// TODO: Fill out
/// </summary>
public enum RenderMode
{
	/// <summary>
	/// TODO: Fill out
	/// </summary>
	Normal,
}

/// <summary>
/// TODO: Fill out
/// </summary>
/// <param name="renderMode"></param>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = false)]
public sealed class RenderModeAttribute(RenderMode renderMode) : Attribute
{
	/// <summary>
	/// TODO: Fill out
	/// </summary>
	public RenderMode RenderMode { get; } = renderMode;
}
