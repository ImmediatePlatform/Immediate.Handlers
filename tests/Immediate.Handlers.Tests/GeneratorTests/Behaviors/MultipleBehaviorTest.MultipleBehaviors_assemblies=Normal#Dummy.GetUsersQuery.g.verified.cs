//HintName: Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed class Handler
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;
		private readonly global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _YetAnotherDummy_SecondLoggingBehavior;
		private readonly global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _YetAnotherDummy_LoggingBehavior;
		private readonly global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _Dummy_SecondLoggingBehavior;
		private readonly global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _YetAnotherDummy_OtherBehavior;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _Dummy_LoggingBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior,
			global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> YetAnotherDummy_SecondLoggingBehavior,
			global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> YetAnotherDummy_LoggingBehavior,
			global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> Dummy_SecondLoggingBehavior,
			global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> YetAnotherDummy_OtherBehavior,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> Dummy_LoggingBehavior
		)
		{
			_handleBehavior = handleBehavior;
			_Dummy_LoggingBehavior = Dummy_LoggingBehavior;
			_YetAnotherDummy_OtherBehavior = YetAnotherDummy_OtherBehavior;
			_Dummy_SecondLoggingBehavior = Dummy_SecondLoggingBehavior;
			_YetAnotherDummy_LoggingBehavior = YetAnotherDummy_LoggingBehavior;
			_YetAnotherDummy_SecondLoggingBehavior = YetAnotherDummy_SecondLoggingBehavior;

			_YetAnotherDummy_SecondLoggingBehavior.SetInnerHandler(_handleBehavior);
			_YetAnotherDummy_LoggingBehavior.SetInnerHandler(_YetAnotherDummy_SecondLoggingBehavior);
			_Dummy_SecondLoggingBehavior.SetInnerHandler(_YetAnotherDummy_LoggingBehavior);
			_YetAnotherDummy_OtherBehavior.SetInnerHandler(_Dummy_SecondLoggingBehavior);
			_Dummy_LoggingBehavior.SetInnerHandler(_YetAnotherDummy_OtherBehavior);
		}

		public async global::System.Threading.Tasks.ValueTask<IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _Dummy_LoggingBehavior
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
}
