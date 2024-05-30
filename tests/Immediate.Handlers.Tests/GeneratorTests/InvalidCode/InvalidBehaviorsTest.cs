using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.InvalidCode;

public class InvalidBehaviorsTest
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task NonBehaviorShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior<,>)
)]
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

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task BoundGenericShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior<GetUsersQuery.Query,IEnumerable<User>>)
)]
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

public class User { }
public class UsersService
{
	public ValueTask<IEnumerable<User>> GetUsers() =>
		ValueTask.FromResult(Enumerable.Empty<User>());
}

public interface ILogger<T>;
""";

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task NonGenericBehaviorShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior)
)]
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

public class LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
	: Behavior<GetUsersQuery.Query,IEnumerable<User>>
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

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task AbstractBehaviorShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior<,>)
)]
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

public abstract class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
	: Behavior<TRequest, TResponse>;

public class User { }
public class UsersService
{
	public ValueTask<IEnumerable<User>> GetUsers() =>
		ValueTask.FromResult(Enumerable.Empty<User>());
}

public interface ILogger<T>;
""";

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task BehaviorHasTooManyTRequestConstraintsShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior<,>)
)]
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
	: Behavior<TRequest, TResponse> where TRequest : IEnumerable, IEquatable<TRequest>
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

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task BehaviorHasTooManyTResponseConstraintsShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior<,>)
)]
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
	: Behavior<TRequest, TResponse> where TResponse : IEnumerable, IEquatable<TResponse>
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

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task BehaviorHasTooManyTypeParametersShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior<,,>)
)]
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

public class LoggingBehavior<TRequest, TResponse, TExtra>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
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

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}
}
