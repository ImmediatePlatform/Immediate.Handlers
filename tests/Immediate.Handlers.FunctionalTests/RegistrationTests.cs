using Immediate.Handlers.FunctionalTests.MultipleBehaviors;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.FunctionalTests;

public sealed class RegistrationTests
{
	[Fact]
	public void RepeatedHandlerRegistrationsAreIdempotent()
	{
		var services = new ServiceCollection();

		_ = MultipleBehaviorHandler.AddHandlers(services);

		Assert.Collection(
			services,

			d => Assert.Equal(typeof(Behavior1<MultipleBehaviorHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(Behavior2<MultipleBehaviorHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(MultipleBehaviorHandler.Handler), d.ServiceType),
			d => Assert.Equal(typeof(IHandler<MultipleBehaviorHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(MultipleBehaviorHandler.HandleBehavior), d.ServiceType)
		);

		_ = MultipleStreamingBehaviorsHandler.AddHandlers(services);

		Assert.Collection(
			services,

			d => Assert.Equal(typeof(Behavior1<MultipleBehaviorHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(Behavior2<MultipleBehaviorHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(MultipleBehaviorHandler.Handler), d.ServiceType),
			d => Assert.Equal(typeof(IHandler<MultipleBehaviorHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(MultipleBehaviorHandler.HandleBehavior), d.ServiceType),

			d => Assert.Equal(typeof(StreamingBehavior1<MultipleStreamingBehaviorsHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(StreamingBehavior2<MultipleStreamingBehaviorsHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(MultipleStreamingBehaviorsHandler.Handler), d.ServiceType),
			d => Assert.Equal(typeof(IStreamingHandler<MultipleStreamingBehaviorsHandler.Query, int>), d.ServiceType),
			d => Assert.Equal(typeof(MultipleStreamingBehaviorsHandler.HandleBehavior), d.ServiceType)
		);
	}
}
