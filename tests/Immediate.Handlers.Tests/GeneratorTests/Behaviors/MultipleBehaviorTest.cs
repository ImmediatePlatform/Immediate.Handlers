using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.Behaviors;

public class MultipleBehaviorTest
{
	private const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

[assembly: Behaviors(
	typeof(LoggingBehavior<,>),
	typeof(YetAnotherDummy.OtherBehavior<,>),
	typeof(SecondLoggingBehavior<,>),
	typeof(YetAnotherDummy.LoggingBehavior<,>),
	typeof(YetAnotherDummy.SecondLoggingBehavior<,>)
)]

namespace YetAnotherDummy
{
	public class User { }
	public class UsersService
	{
		public Task<IEnumerable<User>> GetUsers() =>
			Task.FromResult(Enumerable.Empty<User>());
	}

	public class OtherService
	{
		public Task<IEnumerable<User>> GetUsers() =>
			Task.FromResult(Enumerable.Empty<User>());
	}
	
	public class OtherBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
		: Behavior<TRequest, TResponse>
	{
		public override async Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
		{
			var response = await Next(request, cancellationToken);

			return response;
		}
	}
	
	public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
		: Behavior<TRequest, TResponse>
	{
		public override async Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
		{
			var response = await Next(request, cancellationToken);

			return response;
		}
	}

	public class SecondLoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
		: Behavior<TRequest, TResponse>
	{
		public override async Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
		{
			var response = await Next(request, cancellationToken);

			return response;
		}
	}
}

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
public static class GetUsersQuery
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

public class SecondLoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
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
	public async Task MultipleBehaviors(DriverReferenceAssemblies assemblies)
	{
		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}
}
