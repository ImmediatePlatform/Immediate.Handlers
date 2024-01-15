//HintName: Dummy.GetUsersQuery.g.cs
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed class Handler : global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _HandleBehavior;
		private readonly global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _SecondLoggingBehavior1;
		private readonly global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _LoggingBehavior1;
		private readonly global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _SecondLoggingBehavior;
		private readonly global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _OtherBehavior;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _LoggingBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior HandleBehavior,
			global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> SecondLoggingBehavior1,
			global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> LoggingBehavior1,
			global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> SecondLoggingBehavior,
			global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> OtherBehavior,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> LoggingBehavior
		)
		{
			_HandleBehavior = HandleBehavior;
			_LoggingBehavior = LoggingBehavior;
			_OtherBehavior = OtherBehavior;
			_SecondLoggingBehavior = SecondLoggingBehavior;
			_LoggingBehavior1 = LoggingBehavior1;
			_SecondLoggingBehavior1 = SecondLoggingBehavior1;

			_SecondLoggingBehavior1.SetInnerHandler(_HandleBehavior);
			_LoggingBehavior1.SetInnerHandler(_SecondLoggingBehavior1);
			_SecondLoggingBehavior.SetInnerHandler(_LoggingBehavior1);
			_OtherBehavior.SetInnerHandler(_SecondLoggingBehavior);
			_LoggingBehavior.SetInnerHandler(_OtherBehavior);
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
