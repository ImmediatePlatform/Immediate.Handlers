namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class AddHandlersTests
{
	[Fact]
	public void BehaviorsUseConcreteRegistrations()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[assembly: Behaviors(typeof(LoggingBehavior<,>))]

			public sealed class LoggingBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
			{
				public override ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
					=> Next(request, cancellationToken);
			}

			[Handler]
			public static partial class FirstHandler
			{
				public sealed record Query;
				private static ValueTask<int> HandleAsync(Query query, CancellationToken cancellationToken)
					=> ValueTask.FromResult(1);
			}

			[Handler]
			public static partial class SecondHandler
			{
				public sealed record Command;
				private static ValueTask HandleAsync(Command command, CancellationToken cancellationToken)
					=> ValueTask.CompletedTask;
			}
			"""
		);

		var source = result.GeneratedTrees
			.Single(t => t.FilePath.EndsWith("IH.ServiceCollectionExtensions.g.cs", StringComparison.Ordinal))
			.GetText(TestContext.Current.CancellationToken)
			.ToString();

		Assert.Contains(
			"typeof(global::LoggingBehavior<global::FirstHandler.Query, int>)",
			source,
			StringComparison.Ordinal
		);
		Assert.Contains(
			"typeof(global::LoggingBehavior<global::SecondHandler.Command, global::System.ValueTuple>)",
			source,
			StringComparison.Ordinal
		);
		Assert.DoesNotContain("typeof(global::LoggingBehavior<,>)", source, StringComparison.Ordinal);
	}

	[Theory]
	[MemberData(nameof(Frameworks))]
	public async Task ValidAddHandlerssMethod(string framework)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using Immediate.Handlers.Shared;
			using Microsoft.Extensions.DependencyInjection;
			""",
			skippedSteps: ["Handlers", "HandlersWithBehaviors"]
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result)
			.UseParameters(framework);
	}

	public static TheoryData<string> Frameworks =>
		[Utility.ReferenceAssemblies.TargetFramework];
}
