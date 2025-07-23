using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.Benchmarks;

public sealed record SomeRequest(Guid Id)
	: Mediator.IRequest<SomeResponse>,
	MediatR.IRequest<SomeResponse>;

public sealed record SomeResponse(Guid Id);

public sealed partial class SomeHandlerClass
	: Mediator.IRequestHandler<SomeRequest, SomeResponse>,
	  MediatR.IRequestHandler<SomeRequest, SomeResponse>
{
	private static readonly SomeResponse s_response = new(Guid.NewGuid());

	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	public ValueTask<SomeResponse> Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => ValueTask.FromResult(s_response);

	ValueTask<SomeResponse> Mediator.IRequestHandler<SomeRequest, SomeResponse>.Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => ValueTask.FromResult(s_response);

	Task<SomeResponse> MediatR.IRequestHandler<SomeRequest, SomeResponse>.Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => Task.FromResult(s_response);
}

[Handler]
public static partial class StaticIhExample
{
	private static readonly SomeResponse s_response = new(Guid.NewGuid());

	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	private static ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		CancellationToken token
	) => ValueTask.FromResult(s_response);
}

[Handler]
public sealed partial class SealedIhExample
{
	private static readonly SomeResponse s_response = new(Guid.NewGuid());

	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	private ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		CancellationToken token
	) => ValueTask.FromResult(s_response);
}

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[RankColumn]
#pragma warning disable CA1707 // Identifiers should not contain underscores
public class RequestBenchmarks
{
	private IServiceProvider? _serviceProvider;
	private IServiceProvider? _abstractionServiceProvider;
	private IServiceScope? _serviceScope;
	private IServiceScope? _abstractionServiceScope;
	private Mediator.IMediator? _mediator;
	private Mediator.Mediator? _concreteMediator;
	private MediatR.IMediator? _mediatr;
	private StaticIhExample.Handler? _immediateStaticHandler;
	private SealedIhExample.Handler? _immediateSealedHandler;
	private IHandler<SomeRequest, SomeResponse>? _immediateHandlerAbstraction;
	private SomeHandlerClass? _handler;
	private SomeRequest? _request;

	[GlobalSetup]
	public void Setup()
	{
		var services = new ServiceCollection();

		_ = services.AddBenchmarkLargeHandlers();

		_ = services.AddMediator(opts => opts.ServiceLifetime = ServiceLifetime.Scoped);
		_ = services.AddMediatR(
			cfg => cfg.RegisterServicesFromAssemblyContaining<SomeRequest>()
		);

		_serviceProvider = services.BuildServiceProvider();

		_serviceScope = _serviceProvider.CreateScope();
		_serviceProvider = _serviceScope.ServiceProvider;

		_mediator = _serviceProvider.GetRequiredService<Mediator.IMediator>();
		_concreteMediator = _serviceProvider.GetRequiredService<Mediator.Mediator>();
		_mediatr = _serviceProvider.GetRequiredService<MediatR.IMediator>();
		_immediateStaticHandler = _serviceProvider.GetRequiredService<StaticIhExample.Handler>();
		_immediateSealedHandler = _serviceProvider.GetRequiredService<SealedIhExample.Handler>();
		_handler = _serviceProvider.GetRequiredService<SomeHandlerClass>();
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
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_ImmediateStaticHandler()
	{
		return _immediateStaticHandler!.HandleAsync(_request!, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_ImmediateSealedHandler()
	{
		return _immediateSealedHandler!.HandleAsync(_request!, CancellationToken.None);
	}

	[Benchmark]
	public ValueTask<SomeResponse> SendRequest_ImmediateHandler_Abstraction()
	{
		return _immediateHandlerAbstraction!.HandleAsync(_request!, CancellationToken.None);
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
		return _handler!.Handle(_request!, CancellationToken.None);
	}
}
