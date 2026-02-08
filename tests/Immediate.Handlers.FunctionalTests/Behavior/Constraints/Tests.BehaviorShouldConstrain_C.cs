using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CA1707
namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

// Proving compiler drops these behaviors from handler pipeline
#pragma warning disable IHR0020 // Behavior has incorrect type argument
[Handler]
[Behaviors(typeof(BehaviorA<,>), typeof(BehaviorB<,>), typeof(BehaviorC<,>), typeof(BehaviorD<,>))]
#pragma warning restore IHR0020 // Behavior has incorrect type argument
public static partial class BehaviorShouldConstrainC
{
	public sealed record Query(int Input) : C;

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
	public async Task BehaviorShouldConstrain_C()
	{
		IServiceCollection services = new ServiceCollection();
		services = ConfigureBehaviors(services);
		services = BehaviorShouldConstrainC.AddHandlers(services);
		var serviceProvider = services.BuildServiceProvider();

		var handler = serviceProvider.GetRequiredService<BehaviorShouldConstrainC.Handler>();
		_ = await handler.HandleAsync(new(1), TestContext.Current.CancellationToken);

		var behaviorWalker = serviceProvider.GetRequiredService<BehaviorWalker>();

		Assert.Equal(["BehaviorA", "BehaviorC"], behaviorWalker.BehaviorsRan);
	}
}
