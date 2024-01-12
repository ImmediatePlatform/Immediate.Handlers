using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

#pragma warning disable CA1707
namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

[Handler]
[Behaviors(typeof(BehaviorA<,>), typeof(BehaviorB<,>), typeof(BehaviorC<,>), typeof(BehaviorD<,>))]
public static partial class BehaviorShouldConstrainD
{
	public sealed record Query(int Input) : D;

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
	public async Task BehaviorShouldConstrain_D()
	{
		IServiceCollection services = new ServiceCollection();
		services = ConfigureBehaviors(services);
		services = BehaviorShouldConstrainD.AddHandlers(services);
		var serviceProvider = services.BuildServiceProvider();

		var handler = ActivatorUtilities.CreateInstance<BehaviorShouldConstrainD.Handler>(serviceProvider);
		_ = await handler.HandleAsync(new(1));

		var behaviorWalker = serviceProvider.GetRequiredService<BehaviorWalker>();

		Assert.Contains("BehaviorA", behaviorWalker.BehaviorsRan);
		Assert.Contains("BehaviorB", behaviorWalker.BehaviorsRan);
		Assert.DoesNotContain("BehaviorC", behaviorWalker.BehaviorsRan);
		Assert.Contains("BehaviorD", behaviorWalker.BehaviorsRan);
	}
}
