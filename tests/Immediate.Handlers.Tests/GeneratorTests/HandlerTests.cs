using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests;

public class HandlerTests
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	public async Task IntReturnType(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
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
			""",
			assemblies
		);

		Assert.Equal(
			[
				@"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	public async Task VoidReturnType(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask HandleAsync(
					Query _,
					CancellationToken token)
				{
					return ValueTask.CompletedTask;
				}
			}
			""",
			assemblies
		);

		Assert.Equal(
			[
				@"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	public async Task MissingCancellationToken(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _
				)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			assemblies
		);

		Assert.Equal(
			[
				@"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}
}
