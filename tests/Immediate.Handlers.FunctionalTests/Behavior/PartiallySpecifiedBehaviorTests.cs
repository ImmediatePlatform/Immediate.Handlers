using System.Globalization;
using Immediate.Handlers.Shared;
using Microsoft.Extensions.Logging;
using FakeLogger = Microsoft.Extensions.Logging.Testing.FakeLogger;

namespace Immediate.Handlers.FunctionalTests.Behavior;

/// <summary>
/// Functional tests to prove that behaviors with 0 and 1 type parameters
/// compile and run correctly.
/// </summary>
public sealed class PartiallySpecifiedBehaviorTests
{
	[Fact]
	public async Task BehaviorsAreAttachedToHandlerCorrectly()
	{
		var logger = new FakeLogger();

		var nonGenericTestBehavior = new NonGenericTestBehavior(logger);
		var singleTypeRequestParameterBehavior = new SingleTypeRequestParameterBehavior<int>(logger);
		var singleTypeResponseParameterBehavior = new SingleTypeResponseParameterBehavior<string>(logger);
		var doubleTypeParameterBehavior = new DoubleTypeParameterBehavior<int, string>(logger);
		var multipleBehaviorsTestHandler = new MultipleBehaviorsTestHandler();
		var handleBehavior = new MultipleBehaviorsTestHandler.HandleBehavior(multipleBehaviorsTestHandler);

		var handler = new MultipleBehaviorsTestHandler.Handler(
			handleBehavior,
			doubleTypeParameterBehavior,
			singleTypeResponseParameterBehavior,
			singleTypeRequestParameterBehavior,
			nonGenericTestBehavior
		);

		var response = await handler.HandleAsync(42, TestContext.Current.CancellationToken);

		Assert.True(nonGenericTestBehavior.WasCalled);
		Assert.True(singleTypeRequestParameterBehavior.WasCalled);
		Assert.True(singleTypeResponseParameterBehavior.WasCalled);
		Assert.True(doubleTypeParameterBehavior.WasCalled);

		Assert.Equal("42", response);

		Assert.Equal(4, logger.Collector.Count);
	}
}

#pragma warning disable CA1848 // Use the LoggerMessage delegates

// Non-generic behavior with fixed types
public sealed class NonGenericTestBehavior(ILogger logger)
	: Behavior<int, string>
{
	public bool WasCalled { get; private set; }

	public override async ValueTask<string> HandleAsync(int request, CancellationToken cancellationToken)
	{
		WasCalled = true;
		var response = await Next(request, cancellationToken);
		logger.LogInformation("NonGeneric:{Response}", response);
		return response;
	}
}

// Single type parameter behavior (request type varies, response type is fixed)
public sealed class SingleTypeRequestParameterBehavior<TRequest>(ILogger logger)
	: Behavior<TRequest, string>
{
	public bool WasCalled { get; private set; }

	public override async ValueTask<string> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		WasCalled = true;
		var response = await Next(request, cancellationToken);
		logger.LogInformation("SingleTypeRequest:{Response}", response);
		return response;
	}
}

// Single type parameter behavior (response type varies, request type is fixed)
public sealed class SingleTypeResponseParameterBehavior<TResponse>(ILogger logger)
	: Behavior<int, TResponse>
{
	public bool WasCalled { get; private set; }

	public override async ValueTask<TResponse> HandleAsync(int request, CancellationToken cancellationToken)
	{
		WasCalled = true;
		var response = await Next(request, cancellationToken);
		logger.LogInformation("SingleTypeResponse:{Response}", response);
		return response;
	}
}

// Double type parameter behavior (both types vary)
public sealed class DoubleTypeParameterBehavior<TRequest, TResponse>(ILogger logger)
	: Behavior<TRequest, TResponse>
{
	public bool WasCalled { get; private set; }

	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		WasCalled = true;
		var response = await Next(request, cancellationToken);
		logger.LogInformation("DoubleTypeResponse:{Response}", response);
		return response;
	}
}

[Handler]
[Behaviors(
	typeof(NonGenericTestBehavior),
	typeof(SingleTypeRequestParameterBehavior<>),
	typeof(SingleTypeResponseParameterBehavior<>),
	typeof(DoubleTypeParameterBehavior<,>)
)]
public sealed partial class MultipleBehaviorsTestHandler
{
	private async ValueTask<string> HandleAsync(int request, CancellationToken _)
	{
		return string.Create(CultureInfo.InvariantCulture, $"{request}");
	}
}
