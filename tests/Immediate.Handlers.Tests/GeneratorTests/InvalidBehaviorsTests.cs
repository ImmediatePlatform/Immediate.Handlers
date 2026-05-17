namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class InvalidBehaviorsTests
{
	[Fact]
	public async Task NonBehaviorShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading;
			using System.Threading.Tasks;
			using Dummy;
			using Immediate.Handlers.Shared;

			#pragma warning disable CS9113

			namespace Dummy;

			[Handler]
			[Behaviors(
				typeof(LoggingBehavior<,>)
			)]
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
			{
				public async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					await Task.Delay(1000, cancellationToken);

					return default!;
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
	public async Task BoundGenericShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading;
			using System.Threading.Tasks;
			using Dummy;
			using Immediate.Handlers.Shared;

			#pragma warning disable CS9113

			namespace Dummy;

			[Handler]
			[Behaviors(
				typeof(LoggingBehavior<GetUsersQuery.Query,IEnumerable<User>>)
			)]
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}

	[Fact]
	public async Task AbstractBehaviorShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading;
			using System.Threading.Tasks;
			using Dummy;
			using Immediate.Handlers.Shared;

			#pragma warning disable CS9113

			namespace Dummy;

			[Handler]
			[Behaviors(
				typeof(LoggingBehavior<,>)
			)]
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

			public abstract class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
				: Behavior<TRequest, TResponse>;

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
	public async Task BehaviorHasTooManyTypeParametersShouldProduceNothing()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading;
			using System.Threading.Tasks;
			using Dummy;
			using Immediate.Handlers.Shared;

			#pragma warning disable CS9113

			namespace Dummy;

			[Handler]
			[Behaviors(
				typeof(LoggingBehavior<,,>)
			)]
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

			public class LoggingBehavior<TRequest, TResponse, TExtra>(ILogger<LoggingBehavior<TRequest, TResponse, TExtra>> logger)
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
			"""
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace('\\', '/'))
		);

		_ = await Verify(result);
	}
}
