//HintName: IH.Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed partial class Handler : global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, global::Dummy.GetUsersQuery.Response>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior
		)
		{
			var handlerType = typeof(GetUsersQuery);

			_handleBehavior = handleBehavior;

		}

		public async global::System.Threading.Tasks.ValueTask<global::Dummy.GetUsersQuery.Response> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _handleBehavior
				.HandleAsync(request, cancellationToken)
				.ConfigureAwait(false);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class HandleBehavior : global::Immediate.Handlers.Shared.Behavior<global::Dummy.GetUsersQuery.Query, global::Dummy.GetUsersQuery.Response>
	{
		private readonly global::Dummy.UsersService _usersService;

		public HandleBehavior(
			global::Dummy.UsersService usersService
		)
		{
			_usersService = usersService;
		}

		public override async global::System.Threading.Tasks.ValueTask<global::Dummy.GetUsersQuery.Response> HandleAsync(
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
}
