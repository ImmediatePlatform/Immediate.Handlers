namespace Immediate.Handlers.FunctionalTests.Behavior;

/// <summary>
/// Functional tests to prove that behaviors with 0 and 1 type parameters
/// compile and run correctly.
/// </summary>
public sealed class PartiallySpecifiedBehaviorTests
{
	// Non-generic behavior with fixed types
	private sealed class NonGenericTestBehavior : Shared.Behavior<int, string>
	{
		public bool WasCalled { get; private set; }

		public override async ValueTask<string> HandleAsync(int request, CancellationToken cancellationToken)
		{
			WasCalled = true;
			var response = await Next(request, cancellationToken);
			return $"NonGeneric:{response}";
		}
	}

	// Single type parameter behavior (request type varies, response type is fixed)
	private sealed class SingleTypeParameterBehavior<TRequest> : Shared.Behavior<TRequest, string>
	{
		public bool WasCalled { get; private set; }

		public override async ValueTask<string> HandleAsync(TRequest request, CancellationToken cancellationToken)
		{
			WasCalled = true;
			var response = await Next(request, cancellationToken);
			return $"SingleParam:{response}";
		}
	}

	// Handler behavior for testing
	private sealed class TestHandlerBehavior : Shared.Behavior<int, string>
	{
		public override ValueTask<string> HandleAsync(int request, CancellationToken cancellationToken)
		{
			return ValueTask.FromResult($"Result:{request}");
		}
	}

	[Fact]
	public async Task NonGenericBehavior_ExecutesCorrectly()
	{
		// Arrange
		var nonGenericBehavior = new NonGenericTestBehavior();
		var handlerBehavior = new TestHandlerBehavior();

		nonGenericBehavior.SetInnerHandler(handlerBehavior);
		nonGenericBehavior.HandlerType = typeof(TestHandlerBehavior);

		// Act
		var result = await nonGenericBehavior.HandleAsync(42, CancellationToken.None);

		// Assert
		Assert.True(nonGenericBehavior.WasCalled);
		Assert.Equal("NonGeneric:Result:42", result);
	}

	[Fact]
	public async Task SingleTypeParameterBehavior_ExecutesCorrectly()
	{
		// Arrange
		var singleParamBehavior = new SingleTypeParameterBehavior<int>();
		var handlerBehavior = new TestHandlerBehavior();

		singleParamBehavior.SetInnerHandler(handlerBehavior);
		singleParamBehavior.HandlerType = typeof(TestHandlerBehavior);

		// Act
		var result = await singleParamBehavior.HandleAsync(99, CancellationToken.None);

		// Assert
		Assert.True(singleParamBehavior.WasCalled);
		Assert.Equal("SingleParam:Result:99", result);
	}

	[Fact]
	public async Task NonGenericAndSingleParamBehaviors_CanBeChained()
	{
		// Arrange
		var nonGenericBehavior = new NonGenericTestBehavior();
		var singleParamBehavior = new SingleTypeParameterBehavior<int>();
		var handlerBehavior = new TestHandlerBehavior();

		// Chain: nonGenericBehavior -> singleParamBehavior -> handlerBehavior
		nonGenericBehavior.SetInnerHandler(singleParamBehavior);
		singleParamBehavior.SetInnerHandler(handlerBehavior);

		nonGenericBehavior.HandlerType = typeof(TestHandlerBehavior);
		singleParamBehavior.HandlerType = typeof(TestHandlerBehavior);

		// Act
		var result = await nonGenericBehavior.HandleAsync(123, CancellationToken.None);

		// Assert
		Assert.True(nonGenericBehavior.WasCalled);
		Assert.True(singleParamBehavior.WasCalled);
		Assert.Equal("NonGeneric:SingleParam:Result:123", result);
	}
}
