using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.InvalidCode;

[UsesVerify]
public class InvalidHandlerTest
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task HandlerWithoutHandlerMethodShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
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
public static class GetUsersQuery
{
	public record Query;
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
	public async Task HandlerWithTwoHandlersMethodShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
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
public static class GetUsersQuery
{
	public record Query;

	private static ValueTask<IEnumerable<User>> Handle(
		Query _,
		UsersService usersService,
		CancellationToken token)
	{
		return usersService.GetUsers();
	}

	private static ValueTask<IEnumerable<User>> HandleAsync(
		Query _,
		UsersService usersService,
		CancellationToken token)
	{
		return usersService.GetUsers();
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
	public async Task HandlerWithOneParameterShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
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
public static class GetUsersQuery
{
	public record Query;

	private static ValueTask<IEnumerable<User>> HandleAsync(
		Query _)
	{
		return usersService.GetUsers();
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
	public async Task HandlerWithVoidResponseShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
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
public static class GetUsersQuery
{
	public record Query;

	private static void HandleAsync(
		Query _,
		UsersService usersService,
		CancellationToken token)
	{
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
	public async Task HandlerWithTaskResponseShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
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
public static class GetUsersQuery
{
	public record Query;

	private static Task HandleAsync(
		Query _,
		UsersService usersService,
		CancellationToken token)
	{
		return usersService.GetUsers();
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
	public async Task NestedHandlerShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

public class Wrapper
{
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
