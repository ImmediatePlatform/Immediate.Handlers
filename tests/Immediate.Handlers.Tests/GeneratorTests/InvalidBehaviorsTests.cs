using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests;

public class InvalidBehaviorsTests
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task NonBehaviorShouldProduceNothing(DriverReferenceAssemblies assemblies)
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
			""",
			assemblies
		);

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
	public async Task BoundGenericShouldProduceNothing(DriverReferenceAssemblies assemblies)
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
			""",
			assemblies
		);

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
	public async Task NonGenericBehaviorShouldProduceNothing(DriverReferenceAssemblies assemblies)
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

			public class LoggingBehavior(ILogger<LoggingBehavior> logger)
				: Behavior<GetUsersQuery.Query, IEnumerable<User>>
			{
				public override async ValueTask<IEnumerable<User>> HandleAsync(GetUsersQuery.Query request, CancellationToken cancellationToken)
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
			""",
			assemblies
		);

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
	public async Task AbstractBehaviorShouldProduceNothing(DriverReferenceAssemblies assemblies)
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
			""",
			assemblies
		);

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
	public async Task BehaviorHasTooManyTRequestConstraintsShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System;
			using System.Collections;
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
			""",
			assemblies
		);

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
	public async Task BehaviorHasTooManyTResponseConstraintsShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System;
			using System.Collections;
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
			""",
			assemblies
		);

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
	public async Task BehaviorHasTooManyTypeParametersShouldProduceNothing(DriverReferenceAssemblies assemblies)
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
			""",
			assemblies
		);

		Assert.Equal(
			[],
			result.GeneratedTrees.Select(t => t.FilePath.Replace("\\", "/", StringComparison.Ordinal))
		);

		_ = await Verify(result)
			.UseParameters(string.Join("_", assemblies));
	}
}
