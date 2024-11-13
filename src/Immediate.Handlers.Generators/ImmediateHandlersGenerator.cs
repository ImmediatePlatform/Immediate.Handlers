using System.Collections.Immutable;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Scriban;

namespace Immediate.Handlers.Generators.ImmediateHandlers;

[Generator]
public partial class ImmediateHandlersGenerator : IIncrementalGenerator
{
	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		var hasMsDi = context
			.MetadataReferencesProvider
			.Collect()
			.Select((refs, _) => refs
				.Any(r => (r.Display ?? "")
					.Contains("Microsoft.Extensions.DependencyInjection.Abstractions")));

		var @namespace = context
			.AnalyzerConfigOptionsProvider
			.Select((c, _) => c.GlobalOptions
				.TryGetValue("build_property.rootnamespace", out var ns)
					? ns : null);

		var behaviors = context.SyntaxProvider
			.ForAttributeWithMetadataName(
				"Immediate.Handlers.Shared.BehaviorsAttribute",
				(node, _) => node is CompilationUnitSyntax,
				TransformBehaviors
			)
			.SelectMany((x, _) => x)
			.Collect();

		var handlers = context.SyntaxProvider
			.ForAttributeWithMetadataName(
				"Immediate.Handlers.Shared.HandlerAttribute",
				predicate: (_, _) => true,
				TransformHandler);

		var handlerNodes = handlers
			.Combine(behaviors)
			.Combine(hasMsDi);

		var template = GetTemplate("Handler");
		context.RegisterSourceOutput(
			handlerNodes,
			(spc, node) => RenderHandler(
				spc,
				handler: node.Left.Left,
				behaviors: node.Left.Right,
				hasMsDi: node.Right,
				template)
		);

		var registrationNodes = handlers
			.Select((h, _) => (h?.DisplayName, h?.OverrideBehaviors))
			.Collect()
			.Combine(behaviors)
			.Combine(@namespace
				.Combine(hasMsDi));

		context.RegisterSourceOutput(
			registrationNodes,
			(spc, node) => RenderServiceCollectionExtension(
				spc,
				handlers: node.Left.Left,
				behaviors: node.Left.Right,
				hasDi: node.Right.Right,
				@namespace: node.Right.Left)
		);
	}

	private static void RenderServiceCollectionExtension(
		SourceProductionContext context,
		ImmutableArray<(string? displayName, EquatableReadOnlyList<Behavior?>? behaviors)> handlers,
		ImmutableArray<Behavior?> behaviors,
		bool hasDi,
		string? @namespace)
	{
		var cancellationToken = context.CancellationToken;
		cancellationToken.ThrowIfCancellationRequested();

		if (!hasDi)
			return;

		if (!handlers.Any())
			return;

		if (handlers.Any(h => h.displayName is null || (h.behaviors?.Any(b => b is null) ?? false)))
			return;

		if (behaviors.Any(b => b is null))
			return;

		cancellationToken.ThrowIfCancellationRequested();
		var template = GetTemplate("ServiceCollectionExtensions");

		cancellationToken.ThrowIfCancellationRequested();
		var source = template.Render(new
		{
			Namespace = @namespace,
			Handlers = handlers.Select(x => x.displayName),
			Behaviors = behaviors
				.Concat(handlers.SelectMany(h => h.behaviors ?? Enumerable.Empty<Behavior?>()))
				.Distinct(),
		});

		cancellationToken.ThrowIfCancellationRequested();
		context.AddSource("IH.ServiceCollectionExtensions.g.cs", source);
	}

	private static void RenderHandler(
		SourceProductionContext context,
		Handler? handler,
		ImmutableArray<Behavior?> behaviors,
		bool hasMsDi,
		Template template
	)
	{
		var cancellationToken = context.CancellationToken;
		cancellationToken.ThrowIfCancellationRequested();

		if (handler == null)
			return;

		var responseType = handler.ResponseType ?? new()
		{
			Name = "global::System.ValueTuple",
			Implements = default,
		};

		var pipelineBehaviors = BuildPipeline(
			handler.RequestType,
			responseType,
			handler.OverrideBehaviors?.AsEnumerable()
				?? behaviors.AsEnumerable()
		);

		cancellationToken.ThrowIfCancellationRequested();
		if (pipelineBehaviors.Any(b => b is null))
			return;

		var handlerSource = template.Render(new
		{
			ClassFullyQualifiedName = handler.DisplayName,
			handler.ClassName,
			handler.Namespace,

			handler.MethodName,
			HandlerParameters = handler.Parameters,
			handler.UseToken,

			RequestType = handler.RequestType.Name,
			ResponseType = responseType.Name,
			IsImplicitValueTuple = handler.ResponseType is null,

			Behaviors = BuildRenderBehaviors(pipelineBehaviors),
			HasMsDi = hasMsDi,
		});

		cancellationToken.ThrowIfCancellationRequested();
		context.AddSource($"IH.{handler.Namespace}.{handler.ClassName}.g.cs", handlerSource);
	}

	private static List<Behavior?> BuildPipeline(
			GenericType requestType,
			GenericType responseType,
			IEnumerable<Behavior?> enumerable) =>
		enumerable
			.Where(b => b is null || ValidateType(b.RequestType, requestType))
			.Where(b => b is null || ValidateType(b.ResponseType, responseType))
			.ToList();

	private sealed record RenderBehavior
	{
		public required string NonGenericTypeName { get; init; }
		public required string VariableName { get; init; }
	}

	private static List<RenderBehavior> BuildRenderBehaviors(List<Behavior?> pipelineBehaviors)
	{
		var typesCount = new Dictionary<string, int>()
		{
			["HandleBehavior"] = 1,
		};

		string GetVariableNameSuffix(string typeName)
		{
			if (!typesCount.TryGetValue(typeName, out var count))
				count = 0;

			typesCount[typeName] = count + 1;
			return count == 0 ? string.Empty : $"{count}";
		}

#pragma warning disable CA1308 // Normalize strings to uppercase
		var renderBehaviors = pipelineBehaviors
			.Select(b => new RenderBehavior
			{
				NonGenericTypeName = b!.NonGenericTypeName,
				VariableName = b.Name[0..1].ToLowerInvariant()
					+ b.Name[1..]
					+ GetVariableNameSuffix(b.Name)
			})
			.ToList();
#pragma warning restore CA1308 // Normalize strings to uppercase

		return renderBehaviors;
	}

	private static bool ValidateType(string? type, GenericType implementedTypes) =>
		type is null
		|| implementedTypes.Implements.Contains(type.Replace("_TRequest_", implementedTypes.Name));

	private static Template GetTemplate(string name)
	{
		using var stream = Assembly
			.GetExecutingAssembly()
			.GetManifestResourceStream(
				$"Immediate.Handlers.Generators.Templates.{name}.sbntxt"
			)!;

		using var reader = new StreamReader(stream);
		return Template.Parse(reader.ReadToEnd());
	}
}
