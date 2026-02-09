//HintName: IH.ServiceCollectionExtensions.g.cs
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

#pragma warning disable CS1591

public static class HandlerServiceCollectionExtensions
{
	public static IServiceCollection AddTestsBehaviors(
		this IServiceCollection services)
	{
		services.TryAddTransient(typeof(global::Dummy.ValidationBehavior<>));
		
		return services;
	}

	public static IServiceCollection AddTestsHandlers(
		this IServiceCollection services,
		ServiceLifetime lifetime = ServiceLifetime.Scoped
	)
	{
		global::Dummy.GetUsersQuery.AddHandlers(services, lifetime);
		
		return services;
	}
}
