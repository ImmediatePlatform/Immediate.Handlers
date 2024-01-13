using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

[Handler]
[Behaviors(typeof(BehaviorA<,>), typeof(BehaviorB<,>), typeof(BehaviorC<,>), typeof(BehaviorD<,>))]
public static partial class BehaviorShouldConstrainA
{
	public sealed record Query(int Input) : A;

	private static Task<int> Handle(
		Query query,
		CancellationToken _)
	{
		return Task.FromResult(query.Input + 1);
	}
}

public sealed partial class Tests
{
	[Fact]
	public async Task BehaviorShouldConstrain_A()
	{
		IServiceCollection services = new ServiceCollection();
		services = ConfigureBehaviors(services);
		services = BehaviorShouldConstrainA.AddHandlers(services);
		var serviceProvider = services.BuildServiceProvider();

		var handler = serviceProvider.GetRequiredService<BehaviorShouldConstrainA.Handler>();
		_ = await handler.HandleAsync(new(1));

		var behaviorWalker = serviceProvider.GetRequiredService<BehaviorWalker>();

		Assert.Equal(["BehaviorA"], behaviorWalker.BehaviorsRan);
	}
}
