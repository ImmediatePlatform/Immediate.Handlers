using Immediate.Handlers.Analyzers;
using Immediate.Handlers.CodeFixes;

namespace Immediate.Handlers.Tests.CodeFixTests;

public sealed class HandlerShouldUseCancellationTokenCodeFixProviderTests
{
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
}
