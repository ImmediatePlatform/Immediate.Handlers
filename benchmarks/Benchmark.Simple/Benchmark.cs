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

public sealed partial class TraditionalExample
	: Mediator.IRequestHandler<SomeRequest, SomeResponse>,
	  MediatR.IRequestHandler<SomeRequest, SomeResponse>
{
	private static readonly SomeResponse Response = new(Guid.NewGuid());

	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	public ValueTask<SomeResponse> Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => ValueTask.FromResult(Response);

	ValueTask<SomeResponse> Mediator.IRequestHandler<SomeRequest, SomeResponse>.Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => ValueTask.FromResult(Response);

	Task<SomeResponse> MediatR.IRequestHandler<SomeRequest, SomeResponse>.Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => Task.FromResult(Response);
}

[Foundatio.Mediator.Handler]
public sealed partial class FoundatioHandler
{
	private static readonly SomeResponse Response = new(Guid.NewGuid());

	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	public ValueTask<SomeResponse> Handle(
		SomeRequest request,
		CancellationToken cancellationToken
	) => ValueTask.FromResult(Response);
}

[Handler]
public static partial class StaticIhExample
{
	private static readonly SomeResponse Response = new(Guid.NewGuid());

	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	private static ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		CancellationToken token
	) => ValueTask.FromResult(Response);
}

[Handler]
public sealed partial class SealedIhExample
{
	private static readonly SomeResponse Response = new(Guid.NewGuid());

	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Not Being Tested")]
	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Bench instance method")]
	private ValueTask<SomeResponse> HandleAsync(
		SomeRequest request,
		CancellationToken token
	) => ValueTask.FromResult(Response);
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
	private readonly TraditionalExample _handler;
	private readonly SomeRequest _request;

	public RequestBenchmarks()
	{
		var services = new ServiceCollection();

		_ = services.AddBenchmarkSimpleHandlers();

		_ = services.AddMediator(opts => opts.ServiceLifetime = ServiceLifetime.Scoped);
		_ = services.AddMediatR(
			cfg => cfg.RegisterServicesFromAssemblyContaining<SomeRequest>()
		);

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
		_handler = _serviceProvider.GetRequiredService<TraditionalExample>();
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
		return _handler.Handle(_request, CancellationToken.None);
	}
}
