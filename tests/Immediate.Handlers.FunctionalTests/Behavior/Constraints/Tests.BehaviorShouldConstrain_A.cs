using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

[Handler]
[Behaviors(typeof(BehaviorA<,>), typeof(BehaviorB<,>), typeof(BehaviorC<,>), typeof(BehaviorD<,>))]
[SuppressMessage("Naming", "CA1707", Justification = "Test names.")]
public static partial class BehaviorShouldConstrain_A_Adder
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
		services = BehaviorShouldConstrain_A_Adder.AddHandlers(services);
		var serviceProvider = services.BuildServiceProvider();

		var handler = ActivatorUtilities.CreateInstance<BehaviorShouldConstrain_A_Adder.Handler>(serviceProvider);
		_ = await handler.HandleAsync(new(1));

		var behaviorWalker = serviceProvider.GetRequiredService<BehaviorWalker>();

		Assert.Contains("BehaviorA", behaviorWalker.BehaviorsRan);
		Assert.DoesNotContain("BehaviorB", behaviorWalker.BehaviorsRan);
		Assert.DoesNotContain("BehaviorC", behaviorWalker.BehaviorsRan);
		Assert.DoesNotContain("BehaviorD", behaviorWalker.BehaviorsRan);
	}
}
