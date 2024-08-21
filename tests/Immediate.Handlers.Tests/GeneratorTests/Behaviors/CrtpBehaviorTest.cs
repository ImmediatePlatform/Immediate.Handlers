using System.Diagnostics;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.Behaviors;

public sealed class CrtpBehaviorTest
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task CrtpBehavior(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public interface IConstraint<T> where T : IConstraint<T>
			{
				static abstract bool IsValid(T instance);
			}

			public sealed class ConstraintBehavior<TRequest, TResponse>
				: Behavior<TRequest, TResponse>
				where TRequest : IConstraint<TRequest>
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					if (!TRequest.IsValid(request))
						throw new InvalidOperationException();

					return await Next(request, cancellationToken);
				}
			}

			[Handler]
			[Behaviors(typeof(ConstraintBehavior<,>))]
			public static partial class ConstraintHandler
			{
				public sealed record Command : IConstraint<Command>
				{
					public static bool IsValid(Command instance) => true;

					public int Id { get; init; }
				}

				private static ValueTask HandleAsync(
					Command _,
					CancellationToken __
				) => ValueTask.CompletedTask;
			}
			""",
			assemblies
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH..ConstraintHandler.g.cs",
				.. assemblies switch
				{
					DriverReferenceAssemblies.Normal => Enumerable.Empty<string>(),
					DriverReferenceAssemblies.Msdi =>
						["Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs"],

					_ => throw new UnreachableException(),
				},
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}
}
