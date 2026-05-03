using System.Diagnostics;

namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class StreamingHandlerTests
{
	[Theory]
	[InlineData("")]
	[InlineData("static")]
	public async Task StreamingIntReturnType(string modifier)
	{
		var result = GeneratorTestHelper.RunGenerator(
			$$"""
			using System.Collections.Generic;
			using System.Runtime.CompilerServices;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			
			namespace Dummy;

			[Handler]
			public {{modifier}} partial class GetUsersQuery
			{
				public record Query;

				private {{modifier}} async IAsyncEnumerable<int> HandleAsync(
					Query _,
					[EnumeratorCancellation] CancellationToken token)
				{
					await Task.Yield();
					yield return 0;
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
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task StreamingBehavior(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Collections.Generic;
			using System.Runtime.CompilerServices;
			using System.Threading;
			using System.Threading.Tasks;
			using Dummy;
			using Immediate.Handlers.Shared;

			#pragma warning disable CS9113

			[assembly: Behaviors(
				typeof(LoggingBehavior<,>)
			)]

			namespace Dummy;

			public class GetUsersEndpoint(GetUsersQuery.Handler handler)
			{
				public IAsyncEnumerable<int> GetUsers() =>
					handler.HandleAsync(new GetUsersQuery.Query());
			}

			[Handler]
			public partial class GetUsersQuery(UsersService usersService)
			{
				public record Query;

				private async IAsyncEnumerable<int> HandleAsync(
					Query _,
					[EnumeratorCancellation] CancellationToken token)
				{
					await foreach (var item in usersService.GetUsers(token))
						yield return item;
				}
			}

			public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
				: StreamingBehavior<TRequest, TResponse>
			{
				public override async IAsyncEnumerable<TResponse> HandleAsync(
					TRequest request,
					[EnumeratorCancellation] CancellationToken cancellationToken)
				{
					await foreach (var item in Next(request, cancellationToken))
						yield return item;
				}
			}

			public class UsersService
			{
				public async IAsyncEnumerable<int> GetUsers(
					[EnumeratorCancellation] CancellationToken token)
				{
					await Task.Yield();
					yield return 42;
				}
			}

			public interface ILogger<T>;
			""",
			assemblies
		);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
				.. assemblies switch
				{
					DriverReferenceAssemblies.Normal => Enumerable.Empty<string>(),
					DriverReferenceAssemblies.Msdi =>
						["Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH.ServiceCollectionExtensions.g.cs"],

					DriverReferenceAssemblies.None or _ => throw new UnreachableException(),
				},
			],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result)
			.UseParameters(string.Join('_', assemblies));
	}
}
