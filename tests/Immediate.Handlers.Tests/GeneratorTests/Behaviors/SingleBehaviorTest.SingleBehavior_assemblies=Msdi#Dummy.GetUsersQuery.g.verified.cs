//HintName: Dummy.GetUsersQuery.g.cs
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed class Handler : global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _HandleBehavior;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _LoggingBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior HandleBehavior,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> LoggingBehavior
		)
		{
			_HandleBehavior = HandleBehavior;
			_LoggingBehavior = LoggingBehavior;

			_LoggingBehavior.SetInnerHandler(_HandleBehavior);
		}

		public async global::System.Threading.Tasks.ValueTask<IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _LoggingBehavior
				.HandleAsync(request, cancellationToken)
				.ConfigureAwait(false);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class HandleBehavior : global::Immediate.Handlers.Shared.Behavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.UsersService _usersService;

		public HandleBehavior(
			global::Dummy.UsersService usersService
		)
		{
			_usersService = usersService;
		}

		public override async global::System.Threading.Tasks.ValueTask<IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken
		)
		{
			return await global::Dummy.GetUsersQuery
				.HandleAsync(
					request,
					_usersService,
					cancellationToken
				)
				.ConfigureAwait(false);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddHandlers(
		global::Microsoft.Extensions.DependencyInjection.IServiceCollection services
	)
	{
		services.AddScoped<global::Dummy.GetUsersQuery.Handler>();
		services.AddScoped<global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>>, global::Dummy.GetUsersQuery.Handler>();
		services.AddScoped<global::Dummy.GetUsersQuery.HandleBehavior>();
		return services;
	}
}
