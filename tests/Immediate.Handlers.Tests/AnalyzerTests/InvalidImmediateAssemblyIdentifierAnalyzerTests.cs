using Immediate.Handlers.Analyzers;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public sealed class InvalidImmediateAssemblyIdentifierAnalyzerTests
{
	[Theory]
	[InlineData("_Test")]
	[InlineData("Test_Name")]
	[InlineData("Test123")]
	public async Task ValidIdentifier_DoesNotAlert(string identifier) =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidImmediateAssemblyIdentifierAnalyzer>(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[assembly: ImmediateAssemblyIdentifier("{{identifier}}")]

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
			""").RunAsync(TestContext.Current.CancellationToken);

	[Theory]
	[InlineData("")]
	[InlineData("123Test")]
	[InlineData("Test.Name")]
	[InlineData("Test Name")]
	public async Task InvalidIdentifier_Alerts(string identifier) =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidImmediateAssemblyIdentifierAnalyzer>(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[assembly: {|IHR0023:ImmediateAssemblyIdentifier("{{identifier}}")|}]

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
			""").RunAsync(TestContext.Current.CancellationToken);
}
