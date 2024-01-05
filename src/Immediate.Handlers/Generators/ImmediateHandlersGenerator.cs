using System.Collections.Immutable;
using System.Reflection;
using Immediate.Handlers.Shared;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Scriban;

namespace Immediate.Handlers.Generators;

[Generator]
public class ImmediateHandlersGenerator : IIncrementalGenerator
{
	private sealed record Behavior
	{
		public required string RegistrationType { get; init; }
		public required string ConstructorType { get; init; }
		public required bool IsGeneric { get; init; }
		public required string? TRequest { get; init; }
		public required string? TResponse { get; init; }
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
				"Immediate.Handlers.Shared.RenderModeAttribute",
				(node, _) => node is CompilationUnitSyntax,
				TransformRenderMode
			)
			.Collect();

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
		var attr = context.Attributes[0];
		if (attr.ConstructorArguments.Length > 0)
		{
			var ca = attr.ConstructorArguments[0];
			return (RenderMode?)(int?)ca.Value ?? RenderMode.Normal;
		}
		else
		{
			var pa = attr.NamedArguments[0];
			return (RenderMode?)(int?)pa.Value.Value ?? RenderMode.Normal;
		}
	}

	private static ImmutableArray<Behavior?> TransformBehaviors(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var semanticModel = context.SemanticModel;
		var compilation = semanticModel.Compilation;
		cancellationToken.ThrowIfCancellationRequested();

		var attr = context.Attributes[0];
		if (attr.ConstructorArguments.Length != 1)
			return ImmutableArray<Behavior?>.Empty;

		var ca = attr.ConstructorArguments[0];
		var arrayTypeSymbol = compilation.CreateArrayTypeSymbol(
			compilation.GetTypeByMetadataName("System.Type")!, 1)!;
		if (!SymbolEqualityComparer.Default.Equals(
				ca.Type,
				arrayTypeSymbol
		))
		{
			return ImmutableArray<Behavior?>.Empty;
		}

		cancellationToken.ThrowIfCancellationRequested();
		var behaviorType = typeof(Behavior<,>);
		var behaviorTypeSymbol = compilation.GetTypeByMetadataName(behaviorType.FullName);
		if (behaviorTypeSymbol is null)
			return ImmutableArray<Behavior?>.Empty;

		cancellationToken.ThrowIfCancellationRequested();
		var behaviors = ca.Values
			.Select(v =>
			{
				cancellationToken.ThrowIfCancellationRequested();
				if (v.Value is not INamedTypeSymbol symbol)
					return null;

				var originalDefinition = symbol.OriginalDefinition;
				if (SymbolEqualityComparer.Default.Equals(originalDefinition, behaviorTypeSymbol))
					return null;

				if (!originalDefinition.ImplementsBaseClass(behaviorTypeSymbol))
					return null;

				if (symbol.IsUnboundGenericType && symbol.TypeParameters.Length == 2)
				{
					// services.AddScoped<global::Dummy.LoggingBehavior<,>>();
					// global::Dummy.LoggingBehavior<,>
					var typeName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
					return new Behavior
					{
						RegistrationType = typeName,
						ConstructorType = typeName,
						IsGeneric = true,
						TRequest = null,
						TResponse = null,
					};
				}

				// TODO: 
				// 1. figure out TRequest and TResponse
				// 2. figure out if type is bounded on either side
				throw new NotImplementedException();
			})
			.ToArray();

		return ImmutableArray.Create(behaviors);
	}

	private static void RenderServiceCollectionExtension(SourceProductionContext context, (ImmutableArray<string> handlers, ImmutableArray<Behavior?> behaviors) node)
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
		ImmutableArray<Behavior?> behaviors,
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
