namespace Immediate.Handlers.FunctionalTests.Behavior;

public sealed class BehaviorTests
{
	private sealed class TestBehavior : Shared.Behavior<int, int>
	{
		public override async ValueTask<int> HandleAsync(int request, CancellationToken cancellationToken)
		{
			return await Next(request, cancellationToken);
		}
	}

	[Test]
	public void CannotSetHandlerTwice()
	{
		var handler = new TestBehavior();
		handler.SetInnerHandler(handler);
		_ = Assert.Throws<InvalidOperationException>(() =>
			handler.SetInnerHandler(handler));
	}

	[Test]
	public async Task MustSetHandlerBeforeCallingNext()
	{
		var handler = new TestBehavior();
		_ = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
			await handler.HandleAsync(1, CancellationToken.None));
	}
}
