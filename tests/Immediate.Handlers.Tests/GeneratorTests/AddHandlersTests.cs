namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class AddHandlersTests
{
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
