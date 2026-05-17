namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class InvalidHandlerTests
{
	[Fact]
	public async Task HandlerWithoutHandlerMethodShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task InstanceHandlerMethodWithTooManyParametersShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading;
			using System.Threading.Tasks;
			using Dummy;
			using Immediate.Handlers.Shared;

			namespace Dummy;

			[Handler]
			public sealed class GetUsersQuery
			{
				public record Query;
			
				private ValueTask<IEnumerable<User>> Handle(
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task HandlerWithTwoHandlersMethodShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task HandlerWithNoParametersShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task HandlerWithVoidResponseShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task HandlerWithTaskResponseShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task NestedHandlerShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}
}
