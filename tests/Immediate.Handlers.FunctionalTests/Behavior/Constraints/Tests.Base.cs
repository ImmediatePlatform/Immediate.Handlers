using Immediate.Handlers.Shared;

namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

public record A;

public record B : A;

public record C : A;

public record D : B;

public sealed class BehaviorWalker
{
	public IList<string> BehaviorsRan { get; init; } = [];
}

public sealed class BehaviorA<TRequest, TResponse>(BehaviorWalker walker) : Behavior<TRequest, TResponse> where TRequest : A
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		walker.BehaviorsRan.Add("BehaviorA");
		return await Next(request, cancellationToken);
	}
}

public sealed class BehaviorB<TRequest, TResponse>(BehaviorWalker walker) : Behavior<TRequest, TResponse> where TRequest : B
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		walker.BehaviorsRan.Add("BehaviorB");
		return await Next(request, cancellationToken);
	}
}

public sealed class BehaviorC<TRequest, TResponse>(BehaviorWalker walker) : Behavior<TRequest, TResponse> where TRequest : C
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		walker.BehaviorsRan.Add("BehaviorC");
		return await Next(request, cancellationToken);
	}
}

public sealed class BehaviorD<TRequest, TResponse>(BehaviorWalker walker) : Behavior<TRequest, TResponse> where TRequest : D
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		walker.BehaviorsRan.Add("BehaviorD");
		return await Next(request, cancellationToken);
	}
}
