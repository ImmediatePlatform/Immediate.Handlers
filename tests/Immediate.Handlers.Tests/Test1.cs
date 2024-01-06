namespace Immediate.Handlers.Tests;

[UsesVerify]
public class Test1
{
	[Fact]
	public Task Driver()
	{
		var driver = TestHelper.GetDriver(SourceFragments.Normal);

		return Verify(driver);
	}

	[Fact]
	public Task RunResults()
	{
		var driver = TestHelper.GetDriver(SourceFragments.Normal);

		var runResults = driver.GetRunResult();
		return Verify(runResults);
	}

	[Fact]
	public Task RunResult()
	{
		var driver = TestHelper.GetDriver(SourceFragments.Normal);

		var runResult = driver.GetRunResult().Results.Single();
		return Verify(runResult);
	}
}
