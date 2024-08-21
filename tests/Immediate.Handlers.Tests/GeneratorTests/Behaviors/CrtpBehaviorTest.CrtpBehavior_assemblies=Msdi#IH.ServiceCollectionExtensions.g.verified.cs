//HintName: IH.ServiceCollectionExtensions.g.cs
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

#pragma warning disable CS1591

public static class HandlerServiceCollectionExtensions
{
	public static IServiceCollection AddBehaviors(
		this IServiceCollection services)
	{
		services.TryAddTransient(typeof(global::ConstraintBehavior<,>));
		
		return services;
	}

	public static IServiceCollection AddHandlers(
		this IServiceCollection services,
		ServiceLifetime lifetime = ServiceLifetime.Scoped
	)
	{
		global::ConstraintHandler.AddHandlers(services, lifetime);
		
		return services;
	}
}
