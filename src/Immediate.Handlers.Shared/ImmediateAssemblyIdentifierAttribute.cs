using System.Diagnostics.CodeAnalysis;

namespace Immediate.Handlers.Shared;

/// <summary>
///	    Overrides the name used in the registration methods generated for the assembly.
/// </summary>
/// <param name="identifier">The identifier to use in place of the assembly name.</param>
[AttributeUsage(AttributeTargets.Assembly)]
[ExcludeFromCodeCoverage]
public sealed class ImmediateAssemblyIdentifierAttribute(string identifier) : Attribute
{
	/// <summary>
	///	    The identifier to use in place of the assembly name in generated registration methods.
	/// </summary>
	public string Identifier { get; } = identifier;
}
