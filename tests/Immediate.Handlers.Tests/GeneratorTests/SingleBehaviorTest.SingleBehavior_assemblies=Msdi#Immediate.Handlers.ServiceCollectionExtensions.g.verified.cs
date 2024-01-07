//HintName: Immediate.Handlers.ServiceCollectionExtensions.g.cs
#pragma warning disable CS1591

namespace Microsoft.Extensions.DependencyInjection;

public static class HandlerServiceCollectionExtensions
{
	public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddHandlers(
		this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
	{
		services.AddScoped(typeof(global::Dummy.LoggingBehavior<,>));
		global::Dummy.GetUsersQuery.AddHandlers(services);
		
		return services;
	}
}
