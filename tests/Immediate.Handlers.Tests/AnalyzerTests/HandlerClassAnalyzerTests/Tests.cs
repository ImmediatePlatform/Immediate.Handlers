using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.AnalyzerVerifier<
		Immediate.Handlers.Analyzers.HandlerClassAnalyzer>;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public class Tests
{
	[Fact]
	public async Task HandleMethodDoesNotExist_AlertDiagnostic()
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

[Handler]
public static class GetUsersQuery
{
	public record Query;
}
""";

		var expected = Verifier.Diagnostic("IH0001")
			.WithLocation(11, 21)
			.WithArguments("GetUsersQuery");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			Text,
			DriverReferenceAssemblies.Normal,
			[expected]
		);
		await test.RunAsync();
	}

	[Fact]
	public async Task HandleMethodDoesNotReturnTask_AlertDiagnostic()
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

[Handler]
public static class GetUsersQuery
{
	public record Query;

	private static IEnumerable<User>? HandleAsync(
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
	public Task<IEnumerable<User>> GetUsers()
	{
		_ = logger.ToString();
		return Task.FromResult(Enumerable.Empty<User>());
	}
}

public interface ILogger<T>;
""";

		var expected = Verifier.Diagnostic("IH0002")
			.WithLocation(15, 36)
			.WithArguments("HandleAsync");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			Text,
			DriverReferenceAssemblies.Normal,
			[expected]
		);
		await test.RunAsync();
	}

	[Fact]
	public async Task HandleMethodDoesNotDefineTwoParameters_AlertDiagnostic()
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

[Handler]
public static class GetUsersQuery
{
	public record Query;

	private static Task<int> HandleAsync(
		Query _)
	{
		return Task.FromResult(0);
	}
}
""";

		var expected = Verifier.Diagnostic("IH0003")
			.WithLocation(15, 27)
			.WithArguments("HandleAsync");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			Text,
			DriverReferenceAssemblies.Normal,
			[expected]
		);
		await test.RunAsync();
	}
}
