//HintName: IH.Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed partial class Handler : global::Immediate.Handlers.Shared.IStreamingHandler<global::Dummy.GetUsersQuery.Query, int>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior
		)
		{
			var handlerType = typeof(GetUsersQuery);

			_handleBehavior = handleBehavior;

		}

		public global::System.Collections.Generic.IAsyncEnumerable<int> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return _handleBehavior
				.HandleAsync(request, cancellationToken);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class HandleBehavior : global::Immediate.Handlers.Shared.StreamingBehavior<global::Dummy.GetUsersQuery.Query, int>
	{

		public HandleBehavior(
		)
		{
		}

		public override global::System.Collections.Generic.IAsyncEnumerable<int> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken
		)
		{
			return global::Dummy.GetUsersQuery
				.HandleAsync(
					request
					, cancellationToken
				);
		}
	}
}
