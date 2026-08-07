using Immediate.Handlers.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.FunctionalTests.Tags;

public sealed class TaggedRegistrationTests
{
	[Theory]
	[InlineData(null, typeof(Tag1Handler.Handler), true)]
	[InlineData(null, typeof(Tag2Handler.Handler), true)]
	[InlineData("Tag1", typeof(Tag1Handler.Handler), true)]
	[InlineData("Tag1", typeof(Tag2Handler.Handler), false)]
	[InlineData("Tag2", typeof(Tag1Handler.Handler), false)]
	[InlineData("Tag2", typeof(Tag2Handler.Handler), true)]
	public void TestTag(string? tag, Type type, bool shouldExist)
	{
		var obj = Resolve(tag, type);

		if (shouldExist)
			Assert.NotNull(obj);
		else
			Assert.Null(obj);
	}

	private static object? Resolve(string? tag, Type type)
	{
		var serviceCollection = new ServiceCollection()
			.AddImmediateHandlersFunctionalTestsHandlers(tags: tag is { } ? [tag] : []);

		var serviceProvider = serviceCollection.BuildServiceProvider();
		return serviceProvider.GetService(type);
	}
}

[Handler(Tags = ["Tag1"])]
public static partial class Tag1Handler
{
	public sealed record Query(int Input);

	private static ValueTask<int> HandleAsync(
		Query query,
		CancellationToken _)
	{
		return ValueTask.FromResult(query.Input + 1);
	}
}

[Handler(Tags = ["Tag2"])]
public static partial class Tag2Handler
{
	public sealed record Query(int Input);

	private static ValueTask<int> HandleAsync(Query query, CancellationToken _)
	{
		return ValueTask.FromResult(query.Input + 1);
	}
}
