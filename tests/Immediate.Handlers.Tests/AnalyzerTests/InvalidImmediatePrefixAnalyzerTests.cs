using Immediate.Handlers.Analyzers;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public sealed class InvalidImmediatePrefixAnalyzerTests
{
	[Theory]
	[InlineData("_Test")]
	[InlineData("Test_Name")]
	[InlineData("Test123")]
	public async Task ValidPrefix_DoesNotAlert(string prefix) =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidImmediatePrefixAnalyzer>(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[assembly: ImmediatePrefix("{{prefix}}")]

			namespace Dummy;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _,
					CancellationToken token)
				{
					return ValueTask.FromResult(0);
				}
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Theory]
	[InlineData("")]
	[InlineData("123Test")]
	[InlineData("Test.Name")]
	[InlineData("Test Name")]
	public async Task InvalidPrefix_Alerts(string prefix) =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidImmediatePrefixAnalyzer>(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[assembly: {|IHR0023:ImmediatePrefix("{{prefix}}")|}]

			namespace Dummy;

			[Handler]
			public static partial class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query _,
					CancellationToken token)
				{
					return ValueTask.FromResult(0);
				}
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);
}
