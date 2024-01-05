using System.Collections.Immutable;
using System.Reflection;
using Immediate.Handlers.Utility;
using Microsoft.CodeAnalysis;
using Scriban;

namespace Immediate.Handlers.Generators;

[Generator]
public class ImmediateHandlersGenerator : IIncrementalGenerator
{
	private sealed record Behavior
	{
		public required string Name { get; set; }
		public required string FullTypeName { get; set; }
		public required string? TRequest { get; set; }
		public required string? TResponse { get; set; }
	}

	private sealed record Handler
	{
		public required string Name { get; set; }
		public required string FullTypeName { get; set; }
	}

	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		var globalRenderMode = context.SyntaxProvider
			.ForAttributeWithMetadataName(
				"Immediate.Handlers.Utility.RenderModeAttribute",
				predicate: (_, _) => true,
				TransformRenderMode
			)
			.Collect();

		var behaviors = context.SyntaxProvider
			.ForAttributeWithMetadataName(
				"Immediate.Handlers.Utility.BehaviorsAttribute",
				predicate: (_, _) => true,
				TransformBehaviors
			)
			.SelectMany((x, _) => x)
			.Collect();

		var handlers = context.SyntaxProvider
			.ForAttributeWithMetadataName(
				"Immediate.Handlers.Utility.HandlerAttribute",
				predicate: (_, _) => true,
				TransformHandler);

		var handlerNodes = handlers
			.Combine(behaviors)
			.Combine(globalRenderMode);

		var template = GetTemplate("Handler");
		context.RegisterSourceOutput(
			handlerNodes,
			(spc, node) => RenderHandler(spc, node.Left.Left, node.Left.Right, node.Right, template)
		);

		var registrationNodes = handlers
			.Select((h, _) => h.FullTypeName)
			.Collect()
			.Combine(behaviors);

		context.RegisterSourceOutput(
			registrationNodes,
			RenderServiceCollectionExtension
		);
	}

	private RenderMode TransformRenderMode(GeneratorAttributeSyntaxContext context, CancellationToken token)
	{
		return RenderMode.Normal;
	}

	private static ImmutableArray<Behavior> TransformBehaviors(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	)
	{
		return ImmutableArray.Create<Behavior>();
	}

	private static void RenderServiceCollectionExtension(SourceProductionContext context, (ImmutableArray<string> handlers, ImmutableArray<Behavior> behaviors) node)
	{
		var template = GetTemplate("ServiceCollectionExtensions");
		var source = template.Render(new
		{
			Handlers = node.handlers,
			Behaviors = node.behaviors,
		});
		context.AddSource("Immediate.Handlers.ServiceCollectionExtensions.cs", source);
	}

	private static Handler TransformHandler(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	)
	{
		return default!;
	}

	private static void RenderHandler(
		SourceProductionContext context,
		Handler handler,
		ImmutableArray<Behavior> behaviors,
		ImmutableArray<RenderMode> renderModes,
		Template template
	)
	{

	}

	private static Template GetTemplate(string name)
	{
		using var stream = Assembly
			.GetExecutingAssembly()
			.GetManifestResourceStream(
				$"Immediate.Handlers.Templates.{name}.sbntxt"
			)!;

		using var reader = new StreamReader(stream);
		return Template.Parse(reader.ReadToEnd());
	}
}
