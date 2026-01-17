using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.Benchmarks;

public sealed class DirectTimingBehavior(
	TraditionalExample handler
)
{
	public TimeSpan Elapsed { get; private set; }

	public async ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		CancellationToken cancellationToken
	)
	{
		var sw = Stopwatch.StartNew();
		var response = await handler.Handle(request, cancellationToken);
		Elapsed = sw.Elapsed;
		return response;
	}
}

public sealed class IhTimingBehavior<TRequest, TResponse>
	: Behavior<TRequest, TResponse>
{
	public TimeSpan Elapsed { get; private set; }

	public override async ValueTask<TResponse> HandleAsync(
		TRequest request,
		CancellationToken cancellationToken
	)
	{
		var sw = Stopwatch.StartNew();
		var response = await Next(request, cancellationToken);
		Elapsed = sw.Elapsed;
		return response;
	}
}

[Foundatio.Mediator.Middleware]
public sealed class FTimingMiddleware
{
	public TimeSpan Elapsed { get; private set; }

	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	public Stopwatch Before(SomeRequest request)
	{
		return Stopwatch.StartNew();
	}

	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	[SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Handled by Mediator")]
	public void Finally(SomeRequest request, Stopwatch stopwatch)
	{
		Elapsed = stopwatch.Elapsed;
	}
}

public sealed class MTimingBehavior<TRequest, TResponse>
	: Mediator.IPipelineBehavior<TRequest, TResponse>,
	  MediatR.IPipelineBehavior<TRequest, TResponse>
	where TRequest : Mediator.IRequest<TResponse>, MediatR.IRequest<TResponse>
{
	public TimeSpan Elapsed { get; private set; }

	async ValueTask<TResponse> Mediator.IPipelineBehavior<TRequest, TResponse>.Handle(
		TRequest message,
		Mediator.MessageHandlerDelegate<TRequest, TResponse> next,
		CancellationToken cancellationToken)
	{
		var sw = Stopwatch.StartNew();
		var response = await next(message, cancellationToken);
		Elapsed = sw.Elapsed;
		return response;
	}

	async Task<TResponse> MediatR.IPipelineBehavior<TRequest, TResponse>.Handle(
		TRequest request,
		MediatR.RequestHandlerDelegate<TResponse> next,
		CancellationToken cancellationToken)
	{
		var sw = Stopwatch.StartNew();
		var response = await next(cancellationToken);
		Elapsed = sw.Elapsed;
		return response;
	}
}

public sealed record SomeRequest(Guid Id)
	: Mediator.IRequest<SomeResponse>,
	  MediatR.IRequest<SomeResponse>;

public sealed record SomeResponse(Guid Id);

public sealed class SomeService
{
	private static readonly SomeResponse Response = new(Guid.NewGuid());

	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	public ValueTask<SomeResponse> ServiceHandler(
		SomeRequest request,
		CancellationToken cancellationToken
	) => ValueTask.FromResult(Response);
}

public sealed partial class TraditionalExample(SomeService service)
	: Mediator.IRequestHandler<SomeRequest, SomeResponse>,
	  MediatR.IRequestHandler<SomeRequest, SomeResponse>
{
	public async ValueTask<SomeResponse> Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => await service.ServiceHandler(request, cancellationToken);

	async ValueTask<SomeResponse> Mediator.IRequestHandler<SomeRequest, SomeResponse>.Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => await service.ServiceHandler(request, cancellationToken);

	async Task<SomeResponse> MediatR.IRequestHandler<SomeRequest, SomeResponse>.Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => await service.ServiceHandler(request, cancellationToken);
}

[Foundatio.Mediator.Handler]
public sealed partial class FoundatioHandler(SomeService service)
{
	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	public async ValueTask<SomeResponse> Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => await service.ServiceHandler(request, cancellationToken);
}

[Handler]
[Behaviors(
	typeof(IhTimingBehavior<,>)
)]
public static partial class StaticIhExample
{
	private static async ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		SomeService service,
		CancellationToken cancellationToken
	) => await service.ServiceHandler(request, cancellationToken);
}

[Handler]
[Behaviors(
	typeof(IhTimingBehavior<,>)
)]
public sealed partial class SealedIhExample(SomeService service)
{
	private async ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		CancellationToken cancellationToken
	) => await service.ServiceHandler(request, cancellationToken);
}

[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net10_0)]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[RankColumn]
#pragma warning disable CA1707 // Identifiers should not contain underscores
public class RequestBenchmarks
{
	private readonly IServiceProvider _serviceProvider;
	private readonly IServiceProvider _abstractionServiceProvider;
	private readonly IServiceScope _serviceScope;
	private readonly IServiceScope _abstractionServiceScope;
	private readonly Mediator.IMediator _mediator;
	private readonly Mediator.Mediator _concreteMediator;
	private readonly MediatR.IMediator _mediatr;
	private readonly Foundatio.Mediator.IMediator _foundatioMediator;
	private readonly StaticIhExample.Handler _immediateStaticHandler;
	private readonly SealedIhExample.Handler _immediateSealedHandler;
	private readonly IHandler<SomeRequest, SomeResponse> _immediateHandlerAbstraction;
	private readonly DirectTimingBehavior _handler;
	private readonly SomeRequest _request;

	public RequestBenchmarks()
	{
		var services = new ServiceCollection();

		_ = services.AddScoped<SomeService>();

		_ = services.AddBenchmarkBehaviorsHandlers();
		_ = services.AddBenchmarkBehaviorsBehaviors();

		_ = services.AddMediator(opts => opts.ServiceLifetime = ServiceLifetime.Scoped);
		_ = services.AddScoped(
			typeof(Mediator.IPipelineBehavior<,>),
			typeof(MTimingBehavior<,>)
		);

		_ = services.AddMediatR(
			cfg => cfg.RegisterServicesFromAssemblyContaining<SomeRequest>()
		);
		_ = services.AddScoped(
			typeof(MediatR.IPipelineBehavior<,>),
			typeof(MTimingBehavior<,>)
		);

		_ = services.AddScoped<DirectTimingBehavior>();
		_ = services.AddScoped<TraditionalExample>();

		_ = Foundatio.Mediator.MediatorExtensions.AddMediator(services);

		_serviceProvider = services.BuildServiceProvider();

		_serviceScope = _serviceProvider.CreateScope();
		_serviceProvider = _serviceScope.ServiceProvider;

		_mediator = _serviceProvider.GetRequiredService<Mediator.IMediator>();
		_concreteMediator = _serviceProvider.GetRequiredService<Mediator.Mediator>();
		_mediatr = _serviceProvider.GetRequiredService<MediatR.IMediator>();
		_foundatioMediator = _serviceProvider.GetRequiredService<Foundatio.Mediator.IMediator>();
		_immediateStaticHandler = _serviceProvider.GetRequiredService<StaticIhExample.Handler>();
		_immediateSealedHandler = _serviceProvider.GetRequiredService<SealedIhExample.Handler>();
		_handler = _serviceProvider.GetRequiredService<DirectTimingBehavior>();
		_request = new(Guid.NewGuid());

		_abstractionServiceScope = _serviceProvider.CreateScope();
		_abstractionServiceProvider = _abstractionServiceScope.ServiceProvider;
		_immediateHandlerAbstraction = _abstractionServiceProvider.GetRequiredService<IHandler<SomeRequest, SomeResponse>>();
	}

	[GlobalCleanup]
	public void Cleanup()
	{
		if (_serviceScope is not null)
			_serviceScope.Dispose();
		else
			(_serviceProvider as IDisposable)?.Dispose();

		if (_abstractionServiceScope is not null)
			_abstractionServiceScope.Dispose();
		else
			(_abstractionServiceProvider as IDisposable)?.Dispose();
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_ImmediateStaticHandler()
	{
		return _immediateStaticHandler.HandleAsync(_request, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_ImmediateSealedHandler()
	{
		return _immediateSealedHandler.HandleAsync(_request, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_ImmediateHandler_Abstraction()
	{
		return _immediateHandlerAbstraction.HandleAsync(_request, CancellationToken.None);
	}

	[Benchmark]
	public Task<SomeResponse> SendRequest_MediatR()
	{
		return _mediatr.Send(_request, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_IMediator()
	{
		return _mediator.Send(_request, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_Mediator()
	{
		return _concreteMediator.Send(_request, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_Foundatio()
	{
		return _foundatioMediator.InvokeAsync<SomeResponse>(_request, CancellationToken.None);
	}

	[Benchmark(Baseline = true)]
	public ValueTask<SomeResponse> SendRequest_Baseline()
	{
		return _handler.HandleAsync(_request, CancellationToken.None);
	}
}
