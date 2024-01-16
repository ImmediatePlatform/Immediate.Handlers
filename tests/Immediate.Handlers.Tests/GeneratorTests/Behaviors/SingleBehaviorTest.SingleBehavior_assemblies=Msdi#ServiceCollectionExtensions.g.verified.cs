//HintName: ServiceCollectionExtensions.g.cs
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CS1591

public static class HandlerServiceCollectionExtensions
{
	public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddBehaviors(
		this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
	{
		services.AddScoped(typeof(global::Dummy.LoggingBehavior<,>));
		
		return services;
	}

	public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddHandlers(
		this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
	{
		global::Dummy.GetUsersQuery.AddHandlers(services);
		
		return services;
	}
}
