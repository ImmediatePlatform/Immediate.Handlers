//HintName: IH.Dummy.GetUsersQuery.g.cs
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed partial class Handler : global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;
		private readonly global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> _secondLoggingBehavior1;
		private readonly global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> _loggingBehavior1;
		private readonly global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> _secondLoggingBehavior;
		private readonly global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> _otherBehavior;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> _loggingBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior,
			global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> secondLoggingBehavior1,
			global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> loggingBehavior1,
			global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> secondLoggingBehavior,
			global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> otherBehavior,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> loggingBehavior
		)
		{
			var handlerType = typeof(GetUsersQuery);

			_handleBehavior = handleBehavior;

			_loggingBehavior = loggingBehavior;
			_loggingBehavior.HandlerType = handlerType;

			_otherBehavior = otherBehavior;
			_otherBehavior.HandlerType = handlerType;

			_secondLoggingBehavior = secondLoggingBehavior;
			_secondLoggingBehavior.HandlerType = handlerType;

			_loggingBehavior1 = loggingBehavior1;
			_loggingBehavior1.HandlerType = handlerType;

			_secondLoggingBehavior1 = secondLoggingBehavior1;
			_secondLoggingBehavior1.HandlerType = handlerType;

			_secondLoggingBehavior1.SetInnerHandler(_handleBehavior);
			_loggingBehavior1.SetInnerHandler(_secondLoggingBehavior1);
			_secondLoggingBehavior.SetInnerHandler(_loggingBehavior1);
			_otherBehavior.SetInnerHandler(_secondLoggingBehavior);
			_loggingBehavior.SetInnerHandler(_otherBehavior);
		}

		public async global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _loggingBehavior
				.HandleAsync(request, cancellationToken)
				.ConfigureAwait(false);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class HandleBehavior : global::Immediate.Handlers.Shared.Behavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.UsersService _usersService;

		public HandleBehavior(
			global::Dummy.UsersService usersService
		)
		{
			_usersService = usersService;
		}

		public override async global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken
		)
		{
			return await global::Dummy.GetUsersQuery
				.HandleAsync(
					request
					, _usersService
					, cancellationToken
				)
				.ConfigureAwait(false);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public static IServiceCollection AddHandlers(
		IServiceCollection services,
		ServiceLifetime lifetime = ServiceLifetime.Scoped
	)
	{
		services.Add(new(typeof(global::Dummy.GetUsersQuery.Handler), typeof(global::Dummy.GetUsersQuery.Handler), lifetime));
		services.Add(new(typeof(global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>>), typeof(global::Dummy.GetUsersQuery.Handler), lifetime));
		services.Add(new(typeof(global::Dummy.GetUsersQuery.HandleBehavior), typeof(global::Dummy.GetUsersQuery.HandleBehavior), lifetime));
		return services;
	}
}
