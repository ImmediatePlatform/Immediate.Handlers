namespace Immediate.Handlers.Tests;

[UsesVerify]
public class Test1
{
	[Fact]
	public async Task Driver()
	{
		var driver = TestHelper.GetDriver(SourceFragments.Normal);

		_ = await Verify(driver);
	}

	[Fact]
	public async Task RunResults()
	{
		var driver = TestHelper.GetDriver(SourceFragments.Normal);

		var runResults = driver.GetRunResult();
		_ = await Verify(runResults);
	}

	[Fact]
	public async Task RunResult()
	{
		var driver = TestHelper.GetDriver(SourceFragments.Normal, [DriverReferenceAssemblies.Msdi]);

		var runResult = driver.GetRunResult().Results.Single();
		_ = await Verify(runResult);
	}
}
