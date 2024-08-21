//HintName: IH.ServiceCollectionExtensions.g.cs
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

#pragma warning disable CS1591

public static class HandlerServiceCollectionExtensions
{
	public static IServiceCollection AddBehaviors(
		this IServiceCollection services)
	{
		services.TryAddTransient(typeof(global::Dummy.LoggingBehavior<,>));
		services.TryAddTransient(typeof(global::YetAnotherDummy.OtherBehavior<,>));
		services.TryAddTransient(typeof(global::Dummy.SecondLoggingBehavior<,>));
		services.TryAddTransient(typeof(global::YetAnotherDummy.LoggingBehavior<,>));
		services.TryAddTransient(typeof(global::YetAnotherDummy.SecondLoggingBehavior<,>));
		
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
