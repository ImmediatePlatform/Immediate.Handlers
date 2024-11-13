using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.FunctionalTests;

public static class HandlerResolver
{
	public static T Resolve<T>(Action<IServiceCollection>? serviceCollectionConfigurator = null)
		where T : notnull
	{
		var serviceCollection = new ServiceCollection()
			.AddImmediateHandlersFunctionalTestsHandlers()
			.AddImmediateHandlersFunctionalTestsBehaviors();

		serviceCollectionConfigurator?.Invoke(serviceCollection);

		var serviceProvider = serviceCollection.BuildServiceProvider();
		return serviceProvider.GetRequiredService<T>();
	}
}
