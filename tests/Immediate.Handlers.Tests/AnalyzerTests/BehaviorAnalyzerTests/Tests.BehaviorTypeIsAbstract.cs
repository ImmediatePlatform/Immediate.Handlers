using Immediate.Handlers.Analyzers;

namespace Immediate.Handlers.Tests.AnalyzerTests.BehaviorAnalyzerTests;

public sealed partial class Tests
{
	[Fact]
	public async Task BehaviorTypeIsAbstract_Alerts() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			using Normal;

			[assembly: Behaviors(
				typeof({|IHR0024:LoggingBehavior<,>|})
			)]

			namespace Normal;

			public class User { }
			public interface ILogger<T>;

			public abstract class LoggingBehavior<TRequest, TResponse>
				: Immediate.Handlers.Shared.Behavior<TRequest, TResponse>;

			public class UsersService(ILogger<UsersService> logger)
			{
				public ValueTask<IEnumerable<User>> GetUsers()
				{
					_ = logger.ToString();
					return ValueTask.FromResult(Enumerable.Empty<User>());
				}
			}

			[Handler]
			[Behaviors(
				typeof({|IHR0024:LoggingBehavior<,>|})
			)]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<IEnumerable<User>> HandleAsync(
					Query _,
					UsersService usersService,
					CancellationToken token)
				{
					token.ThrowIfCancellationRequested();
					return usersService.GetUsers();
				}
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);
}
