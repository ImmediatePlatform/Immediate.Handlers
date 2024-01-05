namespace Immediate.Handlers.Utility;

/// <summary>
/// TODO: Fill out
/// </summary>
/// <param name="types"></param>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public sealed class BehaviorsAttribute(params Type[] types) : Attribute
{
	/// <summary>
	/// TODO: Fill out
	/// </summary>
	public Type[] Types { get; } = types;
}
