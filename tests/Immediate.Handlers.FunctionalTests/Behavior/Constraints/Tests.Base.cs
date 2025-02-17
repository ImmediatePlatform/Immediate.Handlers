using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.FunctionalTests.Behavior.Constraints;

public record A;

public record B : A;

public record C : A;

public record D : B;

[SuppressMessage("Naming", "CA1707", Justification = "Test names.")]
public sealed partial class Tests
{
	private static IServiceCollection ConfigureBehaviors(IServiceCollection services)
	{
		_ = services.AddSingleton<BehaviorWalker>();
		_ = services.AddScoped(typeof(BehaviorA<,>));
		_ = services.AddScoped(typeof(BehaviorB<,>));
		_ = services.AddScoped(typeof(BehaviorC<,>));
		_ = services.AddScoped(typeof(BehaviorD<,>));

		return services;
	}
}

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
