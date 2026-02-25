using Immediate.Handlers.Analyzers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

public sealed partial class Tests
{
	[Fact]
	public async Task CrtpBehaviorConstraintIsValid_DoesNotAlert() =>
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
			public interface IValidationTarget<T>;

			public sealed class ValidationBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : IValidationTarget<TRequest>
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					return await Next(request, cancellationToken).ConfigureAwait(false);
				}
			}
			
			public class UsersService
			{
				public ValueTask<IEnumerable<User>> GetUsers()
				{
					return ValueTask.FromResult(Enumerable.Empty<User>());
				}
			}

			[Handler]
			[Behaviors(
				typeof(ValidationBehavior<,>)
			)]
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				public record Query : IValidationTarget<Query>;

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
	public async Task BehaviorTRequestConstraintIsValid_DoesNotAlert() =>
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
			public interface ISomething;

			public sealed class ValidationBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : ISomething
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					return await Next(request, cancellationToken).ConfigureAwait(false);
				}
			}
			
			public class UsersService
			{
				public ValueTask<IEnumerable<User>> GetUsers()
				{
					return ValueTask.FromResult(Enumerable.Empty<User>());
				}
			}

			[Handler]
			[Behaviors(
				typeof(ValidationBehavior<,>)
			)]
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				public record Query : ISomething;

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
	public async Task BehaviorTRequestConstraintIsInvalid_Alerts() =>
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
			public interface ISomething;

			public sealed class ValidationBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : ISomething
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					return await Next(request, cancellationToken).ConfigureAwait(false);
				}
			}
			
			public class UsersService
			{
				public ValueTask<IEnumerable<User>> GetUsers()
				{
					return ValueTask.FromResult(Enumerable.Empty<User>());
				}
			}

			[Handler]
			[Behaviors(
				{|IHR0020:typeof(ValidationBehavior<,>)|}
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
	public async Task BehaviorTResponseConstraintIsValid_DoesNotAlert() =>
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
			public interface ISomething;

			public sealed class ValidationBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TResponse : ISomething
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					return await Next(request, cancellationToken).ConfigureAwait(false);
				}
			}

			public class UsersService
			{
				public ValueTask<IEnumerable<User>> GetUsers()
				{
					return ValueTask.FromResult(Enumerable.Empty<User>());
				}
			}

			[Handler]
			[Behaviors(
				typeof(ValidationBehavior<,>)
			)]
			public sealed partial class GetUsersQuery(UsersService usersService)
			{
				public record Query : ISomething;
				public record Response : ISomething;

				private ValueTask<Response> HandleAsync(
					Query _,
					CancellationToken token)
				{
					token.ThrowIfCancellationRequested();
					var users = usersService.GetUsers();
					return default;
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task BehaviorTResponseConstraintIsInvalid_Alerts() =>
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
			public interface ISomething;

			public sealed class ValidationBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TResponse : ISomething
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
				{
					return await Next(request, cancellationToken).ConfigureAwait(false);
				}
			}
			
			public class UsersService
			{
				public ValueTask<IEnumerable<User>> GetUsers()
				{
					return ValueTask.FromResult(Enumerable.Empty<User>());
				}
			}

			[Handler]
			[Behaviors(
				{|IHR0020:typeof(ValidationBehavior<,>)|}
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
