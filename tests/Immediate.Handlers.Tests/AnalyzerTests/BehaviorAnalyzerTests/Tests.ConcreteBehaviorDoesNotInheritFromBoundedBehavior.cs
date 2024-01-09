using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.AnalyzerVerifier<
		Immediate.Handlers.Analyzers.BehaviorsAnalyzer>;

namespace Immediate.Handlers.Tests.AnalyzerTests.BehaviorAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Fact]
	public async Task ConcreteBehaviorDoesNotInheritFromBoundedBehavior_Alerts()
	{
		const string Text = """
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
	typeof(B1)
)]

namespace Normal;

public class User { };
public interface ILogger<T>;

public class B1 : Behavior<int, int>
{
	public override Task<int> HandleAsync(int request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
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
	typeof(B1)
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
""";

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsAnalyzer>(
			Text,
			DriverReferenceAssemblies.Normal,
			[
				Verifier.Diagnostic("IHR0008").WithSpan(12, 2, 12, 12).WithArguments("B1"),
				Verifier.Diagnostic("IHR0008").WithSpan(39, 2, 39, 12).WithArguments("B1"),
			]
		);
		await test.RunAsync();
	}
}