namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class ImmediateAssemblyIdentifierTests
{
	[Theory]
	[MemberData(nameof(AddHandlersTests.Frameworks), MemberType = typeof(AddHandlersTests))]
	public async Task ImmediateAssemblyIdentifierOverridesAssemblyName(string framework)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[assembly: ImmediateAssemblyIdentifier("Custom")]

			namespace Dummy;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _,
					CancellationToken token)
				{
					return ValueTask.FromResult(0);
				}
			}
			"""
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result)
			.UseParameters(framework);
	}
}
