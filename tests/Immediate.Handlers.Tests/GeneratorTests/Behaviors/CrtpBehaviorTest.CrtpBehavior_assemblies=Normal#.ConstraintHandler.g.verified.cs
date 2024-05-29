//HintName: .ConstraintHandler.g.cs
#pragma warning disable CS1591

partial class ConstraintHandler
{
	public sealed partial class Handler : global::Immediate.Handlers.Shared.IHandler<global::ConstraintHandler.Command, global::System.ValueTuple>
	{
		private readonly global::ConstraintHandler.HandleBehavior _handleBehavior;
		private readonly global::ConstraintBehavior<global::ConstraintHandler.Command, global::System.ValueTuple> _constraintBehavior;

		public Handler(
			global::ConstraintHandler.HandleBehavior handleBehavior,
			global::ConstraintBehavior<global::ConstraintHandler.Command, global::System.ValueTuple> constraintBehavior
		)
		{
			var handlerType = typeof(ConstraintHandler);

			_handleBehavior = handleBehavior;

			_constraintBehavior = constraintBehavior;
			_constraintBehavior.HandlerType = handlerType;

			_constraintBehavior.SetInnerHandler(_handleBehavior);
		}

		public async global::System.Threading.Tasks.ValueTask<global::System.ValueTuple> HandleAsync(
			global::ConstraintHandler.Command request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _constraintBehavior
				.HandleAsync(request, cancellationToken)
				.ConfigureAwait(false);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class HandleBehavior : global::Immediate.Handlers.Shared.Behavior<global::ConstraintHandler.Command, global::System.ValueTuple>
	{

		public HandleBehavior(
		)
		{
		}

		public override async global::System.Threading.Tasks.ValueTask<global::System.ValueTuple> HandleAsync(
			global::ConstraintHandler.Command request,
			global::System.Threading.CancellationToken cancellationToken
		)
		{
			await global::ConstraintHandler
				.HandleAsync(
					request
					, cancellationToken
				)
				.ConfigureAwait(false);

			return default;
		}
	}
}
