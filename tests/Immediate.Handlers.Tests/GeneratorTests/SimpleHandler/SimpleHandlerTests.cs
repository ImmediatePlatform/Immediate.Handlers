using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.SimpleHandler;


public class SimpleHandlerTests
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	public async Task IntReturnType(DriverReferenceAssemblies assemblies)
	{
		var driver = GeneratorTestHelper.GetDriver(
			"""
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public static class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _,
					CancellationToken token)
				{
					return 0;
				}
			}
			""",
			assemblies);

		var result = driver.GetRunResult();
		Assert.Empty(result.Diagnostics);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	public async Task VoidReturnType(DriverReferenceAssemblies assemblies)
	{
		var driver = GeneratorTestHelper.GetDriver(
			"""
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public static class GetUsersQuery
			{
				public record Query;

				private static ValueTask HandleAsync(
					Query _,
					CancellationToken token)
				{
				}
			}
			""",
			assemblies);

		var result = driver.GetRunResult();
		Assert.Empty(result.Diagnostics);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}
}
