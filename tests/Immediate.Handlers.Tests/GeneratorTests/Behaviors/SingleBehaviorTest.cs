using System.Diagnostics;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.Behaviors;

public class SingleBehaviorTest
{
	private const string Input = """
using System.Collections.Generic;
using System.Linq;
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
	public ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
public static partial class GetUsersQuery
{
	public record Query;

	private static ValueTask<IEnumerable<User>> HandleAsync(
		Query _,
		UsersService usersService,
		CancellationToken token)
	{
		return usersService.GetUsers();
	}
}

public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
	: Behavior<TRequest, TResponse>
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		var response = await Next(request, cancellationToken);

		return response;
	}
}

public class User { }
public class UsersService
{
	public ValueTask<IEnumerable<User>> GetUsers() =>
		ValueTask.FromResult(Enumerable.Empty<User>());
}

public interface ILogger<T>;
""";

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task SingleBehavior(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(Input, assemblies);

		Assert.Equal(
			[
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlers.ImmediateHandlersGenerator/IH.Dummy.GetUsersQuery.g.cs",
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
