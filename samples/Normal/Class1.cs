using Immediate.Handlers.Shared;
using Normal;

[assembly: RenderMode(renderMode: RenderMode.Normal)]

[assembly: Behaviors(
	typeof(LoggingBehavior<,>),
	typeof(TestBehavior<,>)
)]

namespace Normal;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public Task<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[Behaviors(
	typeof(LoggingBehavior<,>)
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

public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
	: Behavior<TRequest, TResponse>
{
	public override async Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		_ = logger.ToString();
		var response = await InnerHandler.HandleAsync(request, cancellationToken);

		return response;
	}
}

public class TestBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
	where TRequest : User
{
	public override Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
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

#pragma warning disable CA1040 // Avoid empty interfaces
public interface ILogger<T>;
#pragma warning restore CA1040 // Avoid empty interfaces
