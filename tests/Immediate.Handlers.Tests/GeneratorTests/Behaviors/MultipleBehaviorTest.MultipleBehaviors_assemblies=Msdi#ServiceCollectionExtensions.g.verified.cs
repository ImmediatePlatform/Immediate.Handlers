//HintName: ServiceCollectionExtensions.g.cs
#pragma warning disable CS1591

namespace Microsoft.Extensions.DependencyInjection;

public static class HandlerServiceCollectionExtensions
{
	public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddBehaviors(
		this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
	{
		services.AddScoped(typeof(global::Dummy.LoggingBehavior<,>));
		services.AddScoped(typeof(global::YetAnotherDummy.OtherBehavior<,>));
		services.AddScoped(typeof(global::Dummy.SecondLoggingBehavior<,>));
		services.AddScoped(typeof(global::YetAnotherDummy.LoggingBehavior<,>));
		services.AddScoped(typeof(global::YetAnotherDummy.SecondLoggingBehavior<,>));
		
		return services;
	}

	public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddHandlers(
		this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
	{
		global::Dummy.GetUsersQuery.AddHandlers(services);
		
		return services;
	}
}
