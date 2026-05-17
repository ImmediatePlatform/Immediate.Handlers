using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.Shared;

/// <summary>
///	    Applied to a class to indicate that handler code should be generated.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class HandlerAttribute() : Attribute
{
	/// <summary>
	///	    Applied to a class to indicate that handler code should be generated.
	/// </summary>
	/// <param name="serviceLifetime">
	///		Specifies that the handler should be registered with a specific lifetime.
	/// </param>
	public HandlerAttribute(ServiceLifetime serviceLifetime)
		: this()
	{
		ServiceLifetime = serviceLifetime;
	}

	/// <summary>
	///		The designated <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime"/>
	///		for a particular Handler.
	/// </summary>
	public ServiceLifetime ServiceLifetime { get; } = ServiceLifetime.Scoped;
}
