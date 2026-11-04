using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Tests.GeneratorTests;

public sealed class DebugReportTests
{
	private const string OptionName = "build_property.ImmediateHandlers_GenerateDebugFile";

	private const string SimpleHandler = """
		using System.Threading.Tasks;
		using Immediate.Handlers.Shared;

		[Handler]
		public static partial class QueryHandler
		{
			private static ValueTask<int> Handle(object request) => new(0);
		}
		""";

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("false")]
	[InlineData("FALSE")]
	[InlineData("invalid")]
	[InlineData("1")]
	public void ReportIsDisabledUnlessExplicitlyEnabled(string? value)
	{
		var options = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		if (value is not null)
			options[OptionName] = value;

		var result = GeneratorTestHelper.RunGenerator(SimpleHandler, options);
		Assert.DoesNotContain(result.Results.Single().GeneratedSources, source => string.Equals(source.HintName, "Debug.g.cs", StringComparison.Ordinal));
	}

	[Theory]
	[InlineData("true")]
	[InlineData("TRUE")]
	[InlineData(" True ")]
	public void ReportIsEnabledWithoutChangingOtherGeneratedSources(string value)
	{
		var normal = GeneratorTestHelper.RunGenerator(SimpleHandler);
		var enabled = GeneratorTestHelper.RunGenerator(SimpleHandler, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { [OptionName] = value });

		Assert.Contains("Handler: global::QueryHandler", GetReport(enabled), StringComparison.Ordinal);
		Assert.Contains("No behaviors registered.", GetReport(enabled), StringComparison.Ordinal);
		Assert.Equal(
			normal.Results.Single().GeneratedSources.Select(s => (s.HintName, Text: s.SourceText.ToString())),
			enabled.Results.Single().GeneratedSources.Where(s => !string.Equals(s.HintName, "Debug.g.cs", StringComparison.Ordinal)).Select(s => (s.HintName, Text: s.SourceText.ToString()))
		);
	}

	[Fact]
	public void EnabledReportWithoutHandlers()
	{
		var result = GeneratorTestHelper.RunGenerator("", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { [OptionName] = "true" }, ["Handlers", "HandlersWithBehaviors"]);
		Assert.Contains("No handlers found.", GetReport(result), StringComparison.Ordinal);
	}

	[Fact]
	public async Task ReportsAllHandlersAndBehaviorDecisions()
	{
		var result = GeneratorTestHelper.RunGenerator(
			"""
			using System;
			using System.Collections.Generic;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[assembly: Behaviors(
				typeof(AnyBehavior<,>),
				typeof(RequestBehavior<,>),
				typeof(ResponseBehavior<,>),
				typeof(ExactBehavior),
				typeof(OneParameterBehavior<>),
				typeof(StreamBehavior<,>)
			)]

			public interface IRequest;
			public interface IResponse;
			public sealed record Response : IResponse;
			public sealed record OtherResponse;

			public class AnyBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
			{
				public override ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken token) => Next(request, token);
			}
			public sealed class RequestBehavior<TRequest, TResponse> : AnyBehavior<TRequest, TResponse> where TRequest : IRequest;
			public sealed class ResponseBehavior<TRequest, TResponse> : AnyBehavior<TRequest, TResponse> where TResponse : IResponse;
			public sealed class ExactBehavior : AnyBehavior<Matching.Query, Response>;
			public sealed class OneParameterBehavior<TResponse> : AnyBehavior<Matching.Query, TResponse> where TResponse : IResponse;
			public sealed class StreamBehavior<TRequest, TResponse> : StreamingBehavior<TRequest, TResponse>
			{
				public override IAsyncEnumerable<TResponse> HandleAsync(TRequest request, CancellationToken token) => Next(request, token);
			}

			[Handler]
			public static partial class Matching
			{
				public sealed record Query : IRequest;
				private static ValueTask<Response> HandleAsync(Query query, CancellationToken token) => new(new Response());
			}

			[Handler]
			public static partial class NonMatching
			{
				public sealed record Query;
				private static ValueTask<OtherResponse> Handle(Query query, CancellationToken token) => new(new OtherResponse());
			}

			[Behaviors(typeof(AnyBehavior<,>))]
			public sealed class LocalPipelineAttribute : Attribute;

			[Handler]
			[LocalPipeline]
			public static partial class Override
			{
				private static ValueTask<OtherResponse> Handle(object query, CancellationToken token) => new(new OtherResponse());
			}

			[Handler]
			[Behaviors]
			public static partial class EmptyOverride
			{
				private static ValueTask Handle(object query, CancellationToken token) => default;
			}

			[Handler]
			public static partial class Stream
			{
				private static IAsyncEnumerable<Response> Handle(object query, CancellationToken token) => null!;
			}
			""",
			new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { [OptionName] = "true" }
		);

		_ = await Verify(GetReport(result));
	}

	[Theory]
	[InlineData("NotABehavior", "does not inherit")]
	[InlineData("AbstractBehavior<,>", "is abstract")]
	[InlineData("ValidBehavior<object, int>", "must be unbound")]
	[InlineData("TooManyParameters<,,>", "more than two type parameters")]
	public void ReportsInvalidBehaviorRegistrations(string typeName, string reason)
	{
		ArgumentNullException.ThrowIfNull(typeName);
		var result = GeneratorTestHelper.RunGenerator(
			$$"""
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			[Behaviors(typeof({{typeName}}))]
			public static partial class QueryHandler
			{
				private static ValueTask<int> Handle(object request) => new(0);
			}

			public sealed class NotABehavior;
			public class ValidBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
			{
				public override ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken token) => Next(request, token);
			}
			public abstract class AbstractBehavior<TRequest, TResponse> : ValidBehavior<TRequest, TResponse>;
			public sealed class TooManyParameters<TRequest, TResponse, TExtra> : ValidBehavior<TRequest, TResponse>;
			""",
			new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { [OptionName] = "true" },
			["Handlers", "HandlersWithBehaviors"]
		);

		var report = GetReport(result);
		Assert.Contains(typeName.Split('<')[0], report, StringComparison.Ordinal);
		Assert.Contains(reason, report, StringComparison.Ordinal);
		Assert.Contains("[NOT USED]", report, StringComparison.Ordinal);
		Assert.Contains("Pipeline generation aborted", report, StringComparison.Ordinal);
	}

	private static string GetReport(GeneratorDriverRunResult result) =>
		result.Results.Single().GeneratedSources.Single(s => string.Equals(s.HintName, "Debug.g.cs", StringComparison.Ordinal)).SourceText.ToString();
}
