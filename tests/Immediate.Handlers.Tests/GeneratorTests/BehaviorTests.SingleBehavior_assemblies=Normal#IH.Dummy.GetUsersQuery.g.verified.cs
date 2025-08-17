//HintName: IH.Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed partial class Handler : global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> _loggingBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>> loggingBehavior
		)
		{
			var handlerType = typeof(GetUsersQuery);

			_handleBehavior = handleBehavior;

			_loggingBehavior = loggingBehavior;
			_loggingBehavior.HandlerType = handlerType;

			_loggingBehavior.SetInnerHandler(_handleBehavior);
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
		private readonly global::Dummy.GetUsersQuery _container;

		public HandleBehavior(
			global::Dummy.GetUsersQuery container
		)
		{
			_container = container;
		}

		public override async global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken
		)
		{
			return await _container
				.HandleAsync(
					request
					, cancellationToken
				)
				.ConfigureAwait(false);
		}
	}
}
