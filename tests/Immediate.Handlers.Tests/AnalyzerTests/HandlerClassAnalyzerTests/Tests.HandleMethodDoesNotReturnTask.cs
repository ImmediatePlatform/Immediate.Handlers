using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Test]
	public async Task HandleMethodDoesNotReturnTask_AlertDiagnostic() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static IEnumerable<User>? {|IHR0002:HandleAsync|}(
					Query _,
					UsersService usersService,
					CancellationToken token)
				{
					return null;
				}
			}

			public class User { }
			public class UsersService(ILogger<UsersService> logger)
			{
				public ValueTask<IEnumerable<User>> GetUsers()
				{
					_ = logger.ToString();
					return ValueTask.FromResult(Enumerable.Empty<User>());
				}
			}

			public interface ILogger<T>;
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync();
}
