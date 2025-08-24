using Immediate.Handlers.Tests.Helpers;
using System.Diagnostics;

namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class BehaviorTests
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task SingleBehavior(DriverReferenceAssemblies assemblies)
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
			public partial class GetUsersQuery(UsersService usersService)
			{
				public record Query;

				private ValueTask<IEnumerable<User>> HandleAsync(
					Query _,
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

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task MultipleBehaviors(DriverReferenceAssemblies assemblies)
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
					public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
					{
						var response = await Next(request, cancellationToken);

						return response;
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
			}

			namespace Dummy
			{
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
			}
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
				"Immediate.Handlers.Generators/Immediate.Handlers.Generators.ImmediateHandlersGenerator/IH..ConstraintHandler.g.cs",
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

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	[InlineData(DriverReferenceAssemblies.Msdi)]
	public async Task NestedBehavior(DriverReferenceAssemblies assemblies)
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System;
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading;
			using System.Threading.Tasks;
			using Dummy;
			using Immediate.Handlers.Shared;

			#pragma warning disable CS9113

			namespace Dummy;

			[Behaviors(
				typeof(LoggingBehavior<,>)
			)]
			[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
			public sealed class DefaultBehaviorsAttribute : Attribute;

			public class GetUsersEndpoint(GetUsersQuery.Handler handler)
			{
				public ValueTask<IEnumerable<User>> GetUsers() =>
					handler.HandleAsync(new GetUsersQuery.Query());
			}

			[Handler]
			[DefaultBehaviors]
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
