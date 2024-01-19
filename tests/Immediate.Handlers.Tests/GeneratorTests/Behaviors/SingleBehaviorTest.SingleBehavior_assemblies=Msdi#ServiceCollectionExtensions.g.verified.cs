//HintName: ServiceCollectionExtensions.g.cs
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CS1591

public static class HandlerServiceCollectionExtensions
{
	public static IServiceCollection AddBehaviors(
		this IServiceCollection services)
	{
		services.AddTransient(typeof(global::Dummy.LoggingBehavior<,>));
		
		return services;
	}

	public static IServiceCollection AddHandlers(
		this IServiceCollection services,
		ServiceLifetime lifetime = ServiceLifetime.Scoped
	)
	{
		global::Dummy.GetUsersQuery.AddHandlers(services, lifetime);
		
		return services;
	}
}
