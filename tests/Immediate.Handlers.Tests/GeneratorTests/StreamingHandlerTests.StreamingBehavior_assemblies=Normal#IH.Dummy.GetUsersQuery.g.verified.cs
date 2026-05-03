//HintName: IH.Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed partial class Handler : global::Immediate.Handlers.Shared.IStreamingHandler<global::Dummy.GetUsersQuery.Query, int>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, int> _loggingBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, int> loggingBehavior
		)
		{
			var handlerType = typeof(GetUsersQuery);

			_handleBehavior = handleBehavior;

			_loggingBehavior = loggingBehavior;
			_loggingBehavior.HandlerType = handlerType;

			_loggingBehavior.SetInnerHandler(_handleBehavior);
		}

		public global::System.Collections.Generic.IAsyncEnumerable<int> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return _loggingBehavior
				.HandleAsync(request, cancellationToken);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class HandleBehavior : global::Immediate.Handlers.Shared.StreamingBehavior<global::Dummy.GetUsersQuery.Query, int>
	{
		private readonly global::Dummy.GetUsersQuery _container;

		public HandleBehavior(
			global::Dummy.GetUsersQuery container
		)
		{
			_container = container;
		}

		public override global::System.Collections.Generic.IAsyncEnumerable<int> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken
		)
		{
			return _container
				.HandleAsync(
					request
					, cancellationToken
				);
		}
	}
}
