using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.BehaviorAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public sealed partial class Tests
{
	[Fact]
	public async Task BehaviorTypeWithOneGenericParameter_DoesNotAlert() =>
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
				typeof(RequestLoggingBehavior<>)
			)]

			namespace Normal;

			public class User { }
			public interface ILogger<T>;

			// Single type parameter behavior
			public sealed class RequestLoggingBehavior<TRequest>(ILogger<RequestLoggingBehavior<TRequest>> logger)
				: Immediate.Handlers.Shared.Behavior<TRequest, string>
			{
				public override async ValueTask<string> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					_ = logger.ToString();
					var response = await Next(request, cancellationToken);

					return response;
				}
			}

			public class UsersService(ILogger<UsersService> logger)
			{
				public ValueTask<string> GetUsers()
				{
					_ = logger.ToString();
					return ValueTask.FromResult("result");
				}
			}

			[Handler]
			[Behaviors(
				typeof(RequestLoggingBehavior<>)
			)]
			public static partial class GetUsersQuery
			{
				private static ValueTask<string> HandleAsync(
					int request,
					UsersService usersService,
					CancellationToken token)
				{
					token.ThrowIfCancellationRequested();
					return usersService.GetUsers();
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);
}
