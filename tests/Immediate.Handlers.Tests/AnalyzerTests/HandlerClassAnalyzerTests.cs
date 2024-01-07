using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Analyzers.Diagnostics;
using Immediate.Handlers.Tests.Helpers;
using Verifier =
	Microsoft.CodeAnalysis.CSharp.Testing.XUnit.AnalyzerVerifier<
		Immediate.Handlers.Analyzers.HandlerClassAnalyzer>;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public class HandlerClassAnalyzerTests
{
	[Fact]
	public async Task HandleMethodDoesNotExist_AlertDiagnostic()
	{
		const string Text = @"
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
";

		var expected = Verifier.Diagnostic(HandlerMethodDoesMustExistDiagnostic.Rule)
			.WithLocation(12, 21)
			.WithArguments("GetUsersQuery");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(Text, [expected], [DriverReferenceAssemblies.Normal]);
		await test.RunAsync();
	}

	[Fact]
	public async Task HandleMethodDoesNotReturnTask_AlertDiagnostic()
	{
		const string Text = @"
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
";

		var expected = Verifier.Diagnostic(HandlerMethodMustReturnTaskTDiagnostic.Rule)
			.WithLocation(16, 36)
			.WithArguments("HandleAsync");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(Text, [expected], [DriverReferenceAssemblies.Normal]);
		await test.RunAsync();
	}

	[Fact]
	public async Task HandleMethodDoesNotDefineTwoParameters_AlertDiagnostic()
	{
		const string Text = @"
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

	private static Task<IEnumerable<User>> HandleAsync(
		Query _,
		UsersService usersService)
	{
		return usersService.GetUsers();
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
";

		var expected = Verifier.Diagnostic(HandlerMethodMustDeclareTwoParametersDiagnostic.Rule)
			.WithLocation(16, 41)
			.WithArguments("HandleAsync");

		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(Text, [expected], [DriverReferenceAssemblies.Normal]);
		await test.RunAsync();
	}
}
