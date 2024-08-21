using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.InvalidCode;

public class InvalidHandlerTest
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task HandlerWithoutHandlerMethodShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

[Handler]
public static class GetUsersQuery
{
	public record Query;
}
""";

		var result = GeneratorTestHelper.RunGenerator(Input, assemblies);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task HandlerWithTwoHandlersMethodShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

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

		var result = GeneratorTestHelper.RunGenerator(Input, assemblies);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task HandlerWithNoParametersShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

[Handler]
public static class GetUsersQuery
{
	public record Query;

	private static ValueTask<IEnumerable<User>> HandleAsync()
	{
		return ValueTask.FromResult(Enumerable.Empty<User>());
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

		var result = GeneratorTestHelper.RunGenerator(Input, assemblies);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task HandlerWithVoidResponseShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

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

		var result = GeneratorTestHelper.RunGenerator(Input, assemblies);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task HandlerWithTaskResponseShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

[Handler]
public static class GetUsersQuery
{
	public record Query;

	private static async Task<IEnumerable<User>> HandleAsync(
		Query _,
		UsersService usersService,
		CancellationToken token)
	{
		return await usersService.GetUsers();
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

		var result = GeneratorTestHelper.RunGenerator(Input, assemblies);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task NestedHandlerShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

namespace Dummy;

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

		var result = GeneratorTestHelper.RunGenerator(Input, assemblies);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}
}
