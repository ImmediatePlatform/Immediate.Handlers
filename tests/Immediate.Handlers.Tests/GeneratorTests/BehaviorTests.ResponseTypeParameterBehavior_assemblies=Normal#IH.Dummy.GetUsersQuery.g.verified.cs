//HintName: IH.Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed partial class Handler : global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, global::System.Collections.Generic.IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;
		private readonly global::Dummy.ValidationBehavior<global::Dummy.GetUsersQuery.Query> _validationBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior,
			global::Dummy.ValidationBehavior<global::Dummy.GetUsersQuery.Query> validationBehavior
		)
		{
			var handlerType = typeof(GetUsersQuery);

			_handleBehavior = handleBehavior;

			_validationBehavior = validationBehavior;
			_validationBehavior.HandlerType = handlerType;

			_validationBehavior.SetInnerHandler(_handleBehavior);
		}

		public async global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _validationBehavior
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
