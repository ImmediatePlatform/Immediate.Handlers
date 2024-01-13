using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.Benchmarks;

public sealed class DirectTimingBehavior(
	SomeHandlerClass handler
)
{
	private TimeSpan _elapsed;

	public async ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		CancellationToken cancellationToken
	)
	{
		var sw = Stopwatch.StartNew();
		var response = await handler.Handle(request, cancellationToken);
		_elapsed = sw.Elapsed;
		return response;
	}
}

public sealed class IhTimingBehavior<TRequest, TResponse>
	: Behavior<TRequest, TResponse>
{
	private TimeSpan _elapsed;

	public override async ValueTask<TResponse> HandleAsync(
		TRequest request,
		CancellationToken cancellationToken
	)
	{
		var sw = Stopwatch.StartNew();
		var response = await Next(request, cancellationToken);
		_elapsed = sw.Elapsed;
		return response;
	}
}

public sealed class MTimingBehavior<TRequest, TResponse>
	: Mediator.IPipelineBehavior<TRequest, TResponse>,
	  MediatR.IPipelineBehavior<TRequest, TResponse>
	where TRequest : Mediator.IRequest<TResponse>, MediatR.IRequest<TResponse>
{
	private TimeSpan _elapsed;

	async ValueTask<TResponse> Mediator.IPipelineBehavior<TRequest, TResponse>.Handle(
		TRequest message,
		CancellationToken cancellationToken,
		Mediator.MessageHandlerDelegate<TRequest, TResponse> next)
	{
		var sw = Stopwatch.StartNew();
		var response = await next(message, cancellationToken);
		_elapsed = sw.Elapsed;
		return response;
	}

	async Task<TResponse> MediatR.IPipelineBehavior<TRequest, TResponse>.Handle(
		TRequest request,
		MediatR.RequestHandlerDelegate<TResponse> next,
		CancellationToken cancellationToken)
	{
		var sw = Stopwatch.StartNew();
		var response = await next();
		_elapsed = sw.Elapsed;
		return response;
	}
}

public sealed record SomeRequest(Guid Id)
	: Mediator.IRequest<SomeResponse>,
	  MediatR.IRequest<SomeResponse>;

public sealed record SomeResponse(Guid Id);

public class SomeService
{
	private static readonly SomeResponse Response = new(Guid.NewGuid());

	private static ValueTask<SomeResponse> VtResponse => new(Response);

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	public ValueTask<SomeResponse> ServiceHandler(
		SomeRequest request,
		CancellationToken cancellationToken
	) => VtResponse;
}

[Handler]
[Behaviors(
	typeof(IhTimingBehavior<,>)
)]
public sealed partial class SomeHandlerClass(SomeService service)
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

	private static async ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		SomeService service,
		CancellationToken cancellationToken
	) => await service.ServiceHandler(request, cancellationToken);
}

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[RankColumn]
//[EventPipeProfiler(EventPipeProfile.CpuSampling)]
//[DisassemblyDiagnoser]
//[InliningDiagnoser(logFailuresOnly: true, allowedNamespaces: new[] { "Mediator" })]
#pragma warning disable CA1707 // Identifiers should not contain underscores
public class RequestBenchmarks
{
	private IServiceProvider? _serviceProvider;
	private IServiceScope? _serviceScope;
	private Mediator.IMediator? _mediator;
	private Mediator.Mediator? _concreteMediator;
	private MediatR.IMediator? _mediatr;
	private SomeHandlerClass.Handler? _immediateHandler;
	private DirectTimingBehavior? _handler;
	private SomeRequest? _request;

	[GlobalSetup]
	public void Setup()
	{
		var services = new ServiceCollection();

		_ = services.AddScoped<SomeService>();

		_ = services.AddHandlers();
		_ = services.AddBehaviors();

		_ = services.AddMediator(opts => opts.ServiceLifetime = ServiceLifetime.Scoped);
		_ = services.AddScoped(
			typeof(Mediator.IPipelineBehavior<,>),
			typeof(MTimingBehavior<,>)
		);

		_ = services.AddMediatR(
			cfg => cfg.RegisterServicesFromAssemblyContaining(
				typeof(SomeRequest))
		);
		_ = services.AddScoped(
			typeof(MediatR.IPipelineBehavior<,>),
			typeof(MTimingBehavior<,>)
		);

		_ = services.AddScoped<DirectTimingBehavior>();
		_ = services.AddScoped<SomeHandlerClass>();

		_serviceProvider = services.BuildServiceProvider();

		_serviceScope = _serviceProvider.CreateScope();
		_serviceProvider = _serviceScope.ServiceProvider;

		_mediator = _serviceProvider.GetRequiredService<Mediator.IMediator>();
		_concreteMediator = _serviceProvider.GetRequiredService<Mediator.Mediator>();
		_mediatr = _serviceProvider.GetRequiredService<MediatR.IMediator>();
		_immediateHandler = _serviceProvider.GetRequiredService<SomeHandlerClass.Handler>();
		_handler = _serviceProvider.GetRequiredService<DirectTimingBehavior>();
		_request = new(Guid.NewGuid());
	}

	[GlobalCleanup]
	public void Cleanup()
	{
		if (_serviceScope is not null)
			_serviceScope.Dispose();
		else
			(_serviceProvider as IDisposable)?.Dispose();
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_ImmediateHandler()
	{
		return _immediateHandler!.HandleAsync(_request!, CancellationToken.None);
	}

	[Benchmark]
	public Task<SomeResponse> SendRequest_MediatR()
	{
		return _mediatr!.Send(_request!, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_IMediator()
	{
		return _mediator!.Send(_request!, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_Mediator()
	{
		return _concreteMediator!.Send(_request!, CancellationToken.None);
	}

	[Benchmark(Baseline = true)]
	public ValueTask<SomeResponse> SendRequest_Baseline()
	{
		return _handler!.HandleAsync(_request!, CancellationToken.None);
	}
}
