using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class HandlerTests
{
	[Theory]
	[InlineData("")]
	[InlineData("static")]
	public async Task IntReturnType(string modifier)
	{
		var result = GeneratorTestHelper.RunGenerator(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public {{modifier}} partial class GetUsersQuery
			{
				public record Query;

				private {{modifier}} ValueTask<int> HandleAsync(
					Query _,
					CancellationToken token)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Theory]
	[InlineData("")]
	[InlineData("static")]
	public async Task VoidReturnType(string modifier)
	{
		var result = GeneratorTestHelper.RunGenerator(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public {{modifier}} partial class GetUsersQuery
			{
				public record Query;

				private {{modifier}} ValueTask HandleAsync(
					Query _,
					CancellationToken token)
				{
					return ValueTask.CompletedTask;
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Theory]
	[InlineData("")]
	[InlineData("static")]
	public async Task MissingCancellationToken(string modifier)
	{
		var result = GeneratorTestHelper.RunGenerator(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public {{modifier}} partial class GetUsersQuery
			{
				public record Query;

				private {{modifier}} ValueTask<int> HandleAsync(
					Query _)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task SimpleParameterAttribute()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			using Microsoft.Extensions.DependencyInjection;
			
			namespace Dummy;

			public sealed class SomeKeyedService;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _,
					[FromKeyedServices("SomeServiceKey")] SomeKeyedService service,
					CancellationToken token)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Msdi
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task MultipleParameterAttributes()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			using Microsoft.Extensions.DependencyInjection;
			
			namespace Dummy;

			[AttributeUsage(AttributeTargets.Parameter)]
			public sealed class TestAttribute : Attribute
			{
				public required string Message { get; init; }
			}

			[AttributeUsage(AttributeTargets.Parameter)]
			public sealed class Test2Attribute : Attribute;

			public sealed class SomeKeyedService;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _,
					[FromKeyedServices("SomeServiceKey")] [Test(Message = "Test"), Test2] SomeKeyedService service,
					CancellationToken token)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Msdi
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task ComplexParameterAttribute()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			using Microsoft.Extensions.DependencyInjection;
			
			namespace Dummy;

			[AttributeUsage(AttributeTargets.Parameter)]
			public sealed class TestAttribute(string[] param1, string[] param2, params string[] param3) : Attribute
			{
				public string[] Param1 => param1;
				public string[] Param2 => param2;
				public string[] Param3 => param3;
			}

			public sealed class Service;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _,
					[Test(["Dummy1", "Dummy2"], param2: ["Dummy1", "Dummy2"], "Dummy3", "Dummy4")] Service service,
					CancellationToken token)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Msdi
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task NoHandlersGeneratesZeroFiles(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			namespace Dummy;

			public sealed class Test;
			""",
			assemblies,
			["Handlers", "HandlersWithBehaviors"]
		);

		Assert.Empty(
			result.GeneratedTrees
		);

		_ = await Verify(result);
	}
}
