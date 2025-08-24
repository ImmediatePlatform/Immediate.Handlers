using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CA1707
namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

[Handler]
[Behaviors(typeof(BehaviorA<,>), typeof(BehaviorB<,>), typeof(BehaviorC<,>), typeof(BehaviorD<,>))]
public static partial class BehaviorShouldConstrainD
{
	public sealed record Query(int Input) : D;

	private static ValueTask<int> Handle(
		Query query,
		CancellationToken _)
	{
		return ValueTask.FromResult(query.Input + 1);
	}
}

public sealed partial class Tests
{
	[Fact]
	public async Task BehaviorShouldConstrain_D()
	{
		IServiceCollection services = new ServiceCollection();
		services = ConfigureBehaviors(services);
		services = BehaviorShouldConstrainD.AddHandlers(services);
		var serviceProvider = services.BuildServiceProvider();

		var handler = serviceProvider.GetRequiredService<BehaviorShouldConstrainD.Handler>();
		_ = await handler.HandleAsync(new(1), TestContext.Current.CancellationToken);

		var behaviorWalker = serviceProvider.GetRequiredService<BehaviorWalker>();

		Assert.Equal(["BehaviorA", "BehaviorB", "BehaviorD"], behaviorWalker.BehaviorsRan);
	}
}
