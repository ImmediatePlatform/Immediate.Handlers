using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

#pragma warning disable CA1707
namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

[Handler]
[Behaviors(typeof(BehaviorA<,>), typeof(BehaviorB<,>), typeof(BehaviorC<,>), typeof(BehaviorD<,>))]
public static partial class BehaviorShouldConstrainC
{
	public sealed record Query(int Input) : C;

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
	public async Task BehaviorShouldConstrain_C()
	{
		IServiceCollection services = new ServiceCollection();
		services = ConfigureBehaviors(services);
		services = BehaviorShouldConstrainC.AddHandlers(services);
		var serviceProvider = services.BuildServiceProvider();

		var handler = ActivatorUtilities.CreateInstance<BehaviorShouldConstrainC.Handler>(serviceProvider);
		_ = await handler.HandleAsync(new(1));

		var behaviorWalker = serviceProvider.GetRequiredService<BehaviorWalker>();

		Assert.Contains("BehaviorA", behaviorWalker.BehaviorsRan);
		Assert.DoesNotContain("BehaviorB", behaviorWalker.BehaviorsRan);
		Assert.Contains("BehaviorC", behaviorWalker.BehaviorsRan);
		Assert.DoesNotContain("BehaviorD", behaviorWalker.BehaviorsRan);
	}
}
