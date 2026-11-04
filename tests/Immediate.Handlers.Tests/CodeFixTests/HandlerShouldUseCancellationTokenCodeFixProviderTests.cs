using Immediate.Handlers.Analyzers;
using Immediate.Handlers.CodeFixes;

namespace Immediate.Handlers.Tests.CodeFixTests;

public sealed class HandlerShouldUseCancellationTokenCodeFixProviderTests
{
	/// <summary>Verifies that both handler names and class forms receive the token parameter.</summary>
	[Theory]
	[InlineData("static", "static", "Handle")]
	[InlineData("static", "static", "HandleAsync")]
	[InlineData("sealed", "", "Handle")]
	[InlineData("sealed", "", "HandleAsync")]
	public async Task AddsCancellationTokenParameter(
		string classModifier,
		string methodModifier,
		string methodName
	)
	{
		var className = string.Equals(classModifier, "static", StringComparison.Ordinal) ? "{|IHR0019:GetUsersQuery|}" : "GetUsersQuery";

		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public {{classModifier}} partial class {{className}}
			{
				public record Query;

				private {{methodModifier}} ValueTask<int> {|IHR0012:{{methodName}}|}(Query query) => new(0);
			}
			""",
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public {{classModifier}} partial class {{className}}
			{
				public record Query;

				private {{methodModifier}} ValueTask<int> {{methodName}}(Query query, CancellationToken cancellationToken) => new(0);
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);
	}

	[Fact]
	public async Task AddsCancellationTokenAfterDependencies() =>
		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public static partial class {|IHR0019:GetUsersQuery|}
			{
				public record Query;

				private static ValueTask<int> {|IHR0012:HandleAsync|}(
					Query query,
					object dependency)
				{
					return new(0);
				}
			}
			""",
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public static partial class {|IHR0019:GetUsersQuery|}
			{
				public record Query;

				private static ValueTask<int> HandleAsync(
					Query query,
					object dependency, CancellationToken cancellationToken)
				{
					return new(0);
				}
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AddsCancellationTokenWithoutThreadingUsing() =>
		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(
			"""
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class GetUsersQuery
			{
				public record Query;

				private ValueTask<int> {|IHR0012:Handle|}(Query query) => new(0);
			}
			""",
			"""
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class GetUsersQuery
			{
				public record Query;

				private ValueTask<int> Handle(Query query, System.Threading.CancellationToken cancellationToken) => new(0);
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task FixesMultipleHandlers() =>
		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class FirstHandler
			{
				private ValueTask<int> {|IHR0012:Handle|}(object request) => new(1);
			}

			[Handler]
			public sealed partial class SecondHandler
			{
				private ValueTask<int> {|IHR0012:Handle|}(object request) => new(2);
			}
			""",
			"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class FirstHandler
			{
				private ValueTask<int> Handle(object request, CancellationToken cancellationToken) => new(1);
			}

			[Handler]
			public sealed partial class SecondHandler
			{
				private ValueTask<int> Handle(object request, CancellationToken cancellationToken) => new(2);
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task DoesNotChangeExistingCancellationToken()
	{
		const string Source = """
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class GetUsersQuery
			{
				private ValueTask<int> Handle(object request, CancellationToken token) => new(0);
			}
			""";

		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(Source, Source)
			.RunAsync(TestContext.Current.CancellationToken);
	}

	[Theory]
	[InlineData("cancellationToken", "", "cancellationToken1")]
	[InlineData("query", "var cancellationToken = 0;", "cancellationToken1")]
	[InlineData("cancellationToken", "var cancellationToken1 = 0;", "cancellationToken2")]
	public async Task AvoidsExistingParameterAndLocalNames(string requestName, string body, string tokenName) =>
		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class GetUsersQuery
			{
				private ValueTask<int> {|IHR0012:Handle|}(object {{requestName}})
				{
					{{body}}
					return new(0);
				}
			}
			""",
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class GetUsersQuery
			{
				private ValueTask<int> Handle(object {{requestName}}, CancellationToken {{tokenName}})
				{
					{{body}}
					return new(0);
				}
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	/// <summary>Verifies optional request and dependency parameters keep a valid final optional token.</summary>
	[Theory]
	[InlineData("sealed", "", "object query = null")]
	[InlineData("static", "static", "object query, object dependency = null")]
	public async Task AddsOptionalTokenAfterOptionalParameters(string classModifier, string methodModifier, string parameters)
	{
		var className = string.Equals(classModifier, "static", StringComparison.Ordinal) ? "{|IHR0019:GetUsersQuery|}" : "GetUsersQuery";

		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public {{classModifier}} partial class {{className}}
			{
				private {{methodModifier}} ValueTask<int> {|IHR0012:Handle|}({{parameters}}) => new(0);
			}
			""",
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public {{classModifier}} partial class {{className}}
			{
				private {{methodModifier}} ValueTask<int> Handle({{parameters}}, CancellationToken cancellationToken = default) => new(0);
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);
	}

	[Fact]
	public async Task DoesNotOfferFixAfterParamsParameter()
	{
		const string Source = """
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public sealed partial class GetUsersQuery
			{
				private ValueTask<int> {|IHR0012:Handle|}(params object[] query) => new(0);
			}
			""";

		var test = CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerShouldUseCancellationTokenCodeFixProvider>(Source, Source);
		test.FixedState.MarkupHandling = Microsoft.CodeAnalysis.Testing.MarkupMode.Allow;
		test.NumberOfIncrementalIterations = 0;
		test.NumberOfFixAllIterations = 0;
		await test.RunAsync(TestContext.Current.CancellationToken);
	}
}
