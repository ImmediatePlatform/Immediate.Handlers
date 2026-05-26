namespace Immediate.Handlers.Shared;

/// <summary>
///	    Overrides the name used in the registration methods generated for the assembly.
/// </summary>
/// <remarks>
/// <para>
///	    By default the registration methods are named after the assembly with <c>.</c> and spaces
///	    removed — e.g. an assembly <c>My.App</c> generates <c>AddMyAppHandlers()</c>. Applying
///	    <c>[assembly: ImmediatePrefix("App")]</c> generates <c>AddAppHandlers()</c> instead.
/// </para>
/// <para>
///	    The value must be a valid C# identifier. Other Immediate.* source generators may honor this
///	    attribute so their generated names stay consistent.
/// </para>
/// </remarks>
/// <param name="prefix">The name to use in place of the assembly name.</param>
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class ImmediatePrefixAttribute(string prefix) : Attribute
{
	/// <summary>
	///	    The name to use in place of the assembly name in generated registration methods.
	/// </summary>
	public string Prefix { get; } = prefix;
}
