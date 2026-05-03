using System.Runtime.CompilerServices;
using Immediate.Handlers.Shared;

namespace Immediate.Handlers.FunctionalTests.Streaming;

public sealed class StreamingBehaviorUnitTests
{
	private sealed class TestStreamingBehavior : StreamingBehavior<int, int>
	{
		public override async IAsyncEnumerable<int> HandleAsync(
			int request,
			[EnumeratorCancellation] CancellationToken cancellationToken)
		{
			await foreach (var item in Next(request, cancellationToken))
				yield return item + 1;
		}
	}

	[Fact]
	public async Task CannotSetHandlerTwice()
	{
		var handler = new TestStreamingBehavior();
		handler.SetInnerHandler(handler);
		_ = Assert.Throws<InvalidOperationException>(() =>
			handler.SetInnerHandler(handler));
		await Task.CompletedTask;
	}

	[Fact]
	public async Task MustSetHandlerBeforeCallingNext()
	{
		var handler = new TestStreamingBehavior();
		_ = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
		{
			await foreach (var _ in handler.HandleAsync(1, CancellationToken.None))
				break;
		});
	}
}
