using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public sealed partial class Tests
{
	[Fact]
	public async Task MultiplyInheritedBehaviorTypeIsValid_DoesNotAlert() =>
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

			public abstract class MidBehavior1<TRequest>
				: Immediate.Handlers.Shared.Behavior<TRequest, IEnumerable<User>>;

			public abstract class MidBehavior2 : MidBehavior1<GetUsersQuery.Query>;

			public sealed class TestBehavior(ILogger<TestBehavior> logger) : MidBehavior2
			{
				public override async ValueTask<IEnumerable<User>> HandleAsync(GetUsersQuery.Query request, CancellationToken cancellationToken)
				{
					_ = logger.ToString();
					var response = await Next(request, cancellationToken);
			
					return response;
				}
						}

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
				typeof(TestBehavior)
			)]
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				public record Query;

				private ValueTask<IEnumerable<User>> HandleAsync(
					Query _,
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
	public async Task MultiplyInheritedBehaviorTypeIsInvalid_Alerts() =>
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

			public abstract class MidBehavior1<TRequest>
				: Immediate.Handlers.Shared.Behavior<TRequest, IEnumerable<User>>;

			public abstract class MidBehavior2 : MidBehavior1<int>;

			public sealed class TestBehavior(ILogger<TestBehavior> logger) : MidBehavior2
			{
				public override async ValueTask<IEnumerable<User>> HandleAsync(int request, CancellationToken cancellationToken)
				{
					_ = logger.ToString();
					var response = await Next(request, cancellationToken);
			
					return response;
				}
						}

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
				{|IHR0020:typeof(TestBehavior)|}
			)]
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				public record Query;
			
				private ValueTask<IEnumerable<User>> HandleAsync(
					Query _,
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
