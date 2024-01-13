using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Benchmarks;

public class Benchmark
{
	private ImmediateHandler.Handler _handler = null!;
	private Mediator.ISender _mediatorSender = null!;
	private MediatR.ISender _mediatrSender = null!;

	[GlobalSetup(Target = nameof(ImmediateHandlers))]
	public void GlobalSetupImmediateHandlers()
	{
		IServiceCollection serviceCollection = new ServiceCollection();
		_ = serviceCollection.AddBehaviors();
		_ = serviceCollection.AddHandlers();

		var serviceProvider = serviceCollection.BuildServiceProvider();
		_handler = serviceProvider.GetRequiredService<ImmediateHandler.Handler>();
	}

	[GlobalSetup(Target = nameof(Mediator))]
	public void GlobalSetupMediator()
	{
		IServiceCollection serviceCollection = new ServiceCollection();
		_ = serviceCollection.AddSingleton(typeof(Mediator.IPipelineBehavior<,>), typeof(MediatorBehavior<,>));
		_ = serviceCollection.AddMediator();

		var serviceProvider = serviceCollection.BuildServiceProvider();
		_mediatorSender = serviceProvider.GetRequiredService<Mediator.ISender>();
	}

	[GlobalSetup(Target = nameof(MediatR))]
	public void GlobalSetupMediatR()
	{
		IServiceCollection serviceCollection = new ServiceCollection();
		_ = serviceCollection.AddSingleton(typeof(MediatR.IPipelineBehavior<,>), typeof(MediatrBehavior<,>));
		_ = serviceCollection.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(Benchmark).Assembly));

		var serviceProvider = serviceCollection.BuildServiceProvider();
		_mediatrSender = serviceProvider.GetRequiredService<MediatR.ISender>();
	}

	[Benchmark]
	public async Task ImmediateHandlers()
	{
		_ = await _handler.HandleAsync(new ImmediateHandler.Query(1, 2));
	}

	[Benchmark]
	public async Task Mediator()
	{
		_ = await _mediatorSender.Send(new MediatorRequest(1, 2));
	}

	[Benchmark]
	public async Task MediatR()
	{
		_ = await _mediatrSender.Send(new MediatrRequest(1, 2));
	}

}
