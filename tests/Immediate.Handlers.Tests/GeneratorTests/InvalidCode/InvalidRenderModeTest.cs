using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.GeneratorTests.InvalidCode;


public class InvalidRenderModeTest
{
	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	public async Task InvalidRenderModeOnAssemblyShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading.Tasks;
using Dummy;
using Immediate.Handlers.Shared;

[assembly: RenderMode(renderMode: RenderMode.None)]

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
public static class GetUsersQuery
{
	public record Query;

	private static async ValueTask<IEnumerable<User>> HandleAsync(
		Query _,
		CancellationToken token)
	{
		return [];
	}
}

public class User { }

public interface ILogger<T>;
""";

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}

	[Theory]
	[InlineData(DriverReferenceAssemblies.Normal)]
	public async Task InvalidRenderModeOnHandlerShouldProduceNothing(DriverReferenceAssemblies assemblies)
	{
		const string Input = """
using System.Threading.Tasks;
using Immediate.Handlers.Shared;

namespace Dummy;

public class GetUsersEndpoint(GetUsersQuery.Handler handler)
{
	public async ValueTask<IEnumerable<User>> GetUsers() =>
		handler.HandleAsync(new GetUsersQuery.Query());
}

[Handler]
[RenderMode(renderMode: RenderMode.None)]
public static class GetUsersQuery
{
	public record Query;

	private static async ValueTask<IEnumerable<User>> HandleAsync(
		Query _,
		CancellationToken token)
	{
		return [];
	}
}

public class User { }

public interface ILogger<T>;
""";

		var driver = GeneratorTestHelper.GetDriver(Input, assemblies);

		var runResult = driver.GetRunResult();
		_ = await Verify(runResult)
			.UseParameters(string.Join("_", assemblies));
	}
}
