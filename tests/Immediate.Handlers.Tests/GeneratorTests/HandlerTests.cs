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
			.UseParameters(modifier);
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
			.UseParameters(modifier);
	}

	[Fact]
	public async Task NullableParameterType()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			#nullable enable

			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public partial class GetUsersQuery
			{
				public record Query;
				public record Response;

				private ValueTask<Response> HandleAsync(
					Query? _,
					CancellationToken token)
				{
					return ValueTask.FromResult<Response>(new());
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

		_ = await Verify(result);
	}

	[Fact]
	public async Task NullableReturnType()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			#nullable enable

			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public partial class GetUsersQuery
			{
				public record Query;
				public record Response;

				private ValueTask<Response?> HandleAsync(
					Query? _,
					CancellationToken token)
				{
					return ValueTask.FromResult<Response?>(new());
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
			.UseParameters(modifier);
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
			"""
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
			"""
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
			"""
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
	public async Task NoHandlersGeneratesZeroFiles()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			namespace Dummy;

			public sealed class Test;
			""",
			["Handlers", "HandlersWithBehaviors"]
		);

		Assert.Empty(
			result.GeneratedTrees
		);

		_ = await Verify(result);
	}

	[Theory]
	[InlineData("Transient")]
	[InlineData("Scoped")]
	[InlineData("Singleton")]
	public async Task ServiceLifetime(string lifetime)
	{
		var result = GeneratorTestHelper.RunGenerator(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			using Microsoft.Extensions.DependencyInjection;
			
			namespace Dummy;

			[Handler(ServiceLifetime.{{lifetime}})]
			public sealed partial class GetUsersQuery
			{
				public record Query;

				private ValueTask<int> HandleAsync(
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
			.UseParameters(lifetime);
	}

}
