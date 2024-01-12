using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.BehaviorAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Fact]
	public async Task BehaviorTypeIsUsedMoreThanOnce_Alerts() =>
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
				typeof(LoggingBehavior<,>),
				typeof({|IHR0010:LoggingBehavior<,>|})
			)]

			namespace Normal;

			public class User { };
			public interface ILogger<T>;

			public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
				: Immediate.Handlers.Shared.Behavior<TRequest, TResponse>
			{
				public override async Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					_ = logger.ToString();
					var response = await Next(request, cancellationToken);
			
					return response;
				}
			}
			
			public class UsersService(ILogger<UsersService> logger)
			{
				public Task<IEnumerable<User>> GetUsers()
				{
					_ = logger.ToString();
					return Task.FromResult(Enumerable.Empty<User>());
				}
			}

			[Handler]
			[Behaviors(
				typeof(LoggingBehavior<,>),
				typeof({|IHR0010:LoggingBehavior<,>|})
			)]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static Task<IEnumerable<User>> HandleAsync(
					Query _,
					UsersService usersService,
					CancellationToken token)
				{
					token.ThrowIfCancellationRequested();
					return usersService.GetUsers();
				}
			}
			""",
			DriverReferenceAssemblies.Normal,
			[]
		).RunAsync();
}