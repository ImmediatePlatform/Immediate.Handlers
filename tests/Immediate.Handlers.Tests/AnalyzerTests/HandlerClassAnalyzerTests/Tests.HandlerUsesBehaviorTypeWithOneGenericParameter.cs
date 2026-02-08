using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public sealed partial class Tests
{
	[Fact]
	public async Task BehaviorTypeWithCorrectTRequest_DoesNotAlert() =>
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
			using Normal;

			namespace Normal;

			public class User { }
			public interface ILogger<T>;

			// Single type parameter behavior
			public sealed class RequestLoggingBehavior<TResponse>(ILogger<RequestLoggingBehavior<TResponse>> logger)
				: Immediate.Handlers.Shared.Behavior<int, TResponse>
			{
				public override async ValueTask<TResponse> HandleAsync(int request, CancellationToken cancellationToken)
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
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				private ValueTask<string> HandleAsync(
					int request,
					CancellationToken token)
				{
					token.ThrowIfCancellationRequested();
					return usersService.GetUsers();
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task BehaviorTypeWithIncorrectTRequest_Alerts() =>
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
			using Normal;

			namespace Normal;

			public class User { }
			public interface ILogger<T>;

			// Single type parameter behavior
			public sealed class RequestLoggingBehavior<TResponse>(ILogger<RequestLoggingBehavior<TResponse>> logger)
				: Immediate.Handlers.Shared.Behavior<double, TResponse>
			{
				public override async ValueTask<TResponse> HandleAsync(double request, CancellationToken cancellationToken)
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
				{|IHR0020:typeof(RequestLoggingBehavior<>)|}
			)]
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				private ValueTask<string> HandleAsync(
					int request,
					CancellationToken token)
				{
					token.ThrowIfCancellationRequested();
					return usersService.GetUsers();
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task BehaviorTypeWithCorrectTResponse_DoesNotAlert() =>
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
			using Normal;

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
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				private ValueTask<string> HandleAsync(
					int request,
					CancellationToken token)
				{
					token.ThrowIfCancellationRequested();
					return usersService.GetUsers();
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task BehaviorTypeWithIncorrectTResponse_Alerts() =>
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
			using Normal;

			namespace Normal;

			public class User { }
			public interface ILogger<T>;

			// Single type parameter behavior
			public sealed class RequestLoggingBehavior<TRequest>(ILogger<RequestLoggingBehavior<TRequest>> logger)
				: Immediate.Handlers.Shared.Behavior<TRequest, double>
			{
				public override async ValueTask<double> HandleAsync(TRequest request, CancellationToken cancellationToken)
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
				{|IHR0020:typeof(RequestLoggingBehavior<>)|}
			)]
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				private ValueTask<string> HandleAsync(
					int request,
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
