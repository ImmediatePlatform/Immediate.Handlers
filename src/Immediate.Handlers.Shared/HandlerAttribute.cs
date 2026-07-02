using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.Shared;

/// <summary>
///	    Applied to a class to indicate that handler code should be generated.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
[ExcludeFromCodeCoverage]
public sealed class HandlerAttribute() : Attribute
{
	/// <summary>
	///	    Applied to a class to indicate that handler code should be generated. This
	///	    constructor allows specifying a lifetime to override the app-wide default
	///	    lifetime, usually <see cref="ServiceLifetime.Scoped" />.
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
	///	<para>
	///		The designated <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime"/>
	///		for a particular Handler.
	///	</para>
	///	<para>
	///		If <see langword="null"/>, the lifetime was not provided, and the handler will be
	///		registered according to the app-wide default lifetime, usually <see
	///		cref="ServiceLifetime.Scoped" />.
	///	</para>
	/// </summary>
	public ServiceLifetime? ServiceLifetime { get; }
}
