using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.BehaviorAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public sealed partial class Tests
{
	[Fact]
	public async Task BehaviorTypeWithZeroGenericParameters_DoesNotAlert() =>
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
				typeof(SimpleLoggingBehavior)
			)]

			namespace Normal;

			public class User { }
			public interface ILogger<T>;

			// Non-generic behavior with fixed types
			public sealed class SimpleLoggingBehavior(ILogger<SimpleLoggingBehavior> logger)
				: Immediate.Handlers.Shared.Behavior<int, string>
			{
				public override async ValueTask<string> HandleAsync(int request, CancellationToken cancellationToken)
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
				typeof(SimpleLoggingBehavior)
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
