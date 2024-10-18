using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests;

public class HandlerTests
{
	[Test]
	[Arguments(DriverReferenceAssemblies.Normal)]
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
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Test]
	[Arguments(DriverReferenceAssemblies.Normal)]
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
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Test]
	[Arguments(DriverReferenceAssemblies.Normal)]
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
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Test]
	[Arguments(DriverReferenceAssemblies.Msdi)]
	public async Task SimpleParameterAttribute(DriverReferenceAssemblies assemblies)
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
			assemblies
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Test]
	[Arguments(DriverReferenceAssemblies.Msdi)]
	public async Task MultipleParameterAttributes(DriverReferenceAssemblies assemblies)
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
			assemblies
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Test]
	[Arguments(DriverReferenceAssemblies.Msdi)]
	public async Task ComplexParameterAttribute(DriverReferenceAssemblies assemblies)
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
			assemblies
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs",
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}
}
