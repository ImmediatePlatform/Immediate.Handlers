namespace Immediate.Handlers.Shared;

/// <summary>
///	    Applied to a class to indicate that handler code should be generated.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class HandlerAttribute : Attribute;
