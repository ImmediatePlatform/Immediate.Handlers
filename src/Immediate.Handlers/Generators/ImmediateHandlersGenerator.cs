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
		public required string? RequestType { get; init; }
		public required string? ResponseType { get; init; }
	}

	private sealed record Parameter
	{
		public required string Type { get; init; }
		public required string Name { get; init; }
	}

	private sealed record GenericType
	{
		public required string Name { get; init; }
		public required EquatableReadOnlyList<string> Implements { get; init; }
	}

	private sealed record Handler
	{
		public required string Namespace { get; init; }
		public required string ClassName { get; init; }
		public required string DisplayName { get; init; }

		public required GenericType RequestType { get; init; }
		public required GenericType ResponseType { get; init; }

		public required EquatableReadOnlyList<Parameter> Parameters { get; init; }

		public EquatableReadOnlyList<Behavior>? OverrideBehaviors { get; init; }
		public RenderMode? OverrideRenderMode { get; init; }

	}

	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		var hasMsDi = context
			.MetadataReferencesProvider
			.Collect()
			.Select((refs, _) => refs.Any(r => (r.Display ?? "").Contains("Microsoft.Extensions.DependencyInjection.Abstractions")));

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
			.Combine(globalRenderMode
				.Combine(hasMsDi));

		var template = GetTemplate("Handler");
		context.RegisterSourceOutput(
			handlerNodes,
			(spc, node) => RenderHandler(spc, node.Left.Left, node.Left.Right, node.Right.Left, node.Right.Right, template)
		);

		var registrationNodes = handlers
			.Select((h, _) => h?.DisplayName)
			.Collect()
			.Combine(behaviors)
			.Combine(hasMsDi);

		context.RegisterSourceOutput(
			registrationNodes,
			(spc, node) => RenderServiceCollectionExtension(spc, node.Left.Left, node.Left.Right, node.Right)
		);
	}

	private RenderMode TransformRenderMode(GeneratorAttributeSyntaxContext context, CancellationToken token)
	{
		var attr = context.Attributes[0];
		if (attr.ConstructorArguments.Length > 0)
		{
			var ca = attr.ConstructorArguments[0];
			return (RenderMode?)(int?)ca.Value ?? RenderMode.None;
		}
		else
		{
			var pa = attr.NamedArguments[0];
			return (RenderMode?)(int?)pa.Value.Value ?? RenderMode.None;
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

				var typeName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
				if (symbol.IsUnboundGenericType && symbol.TypeParameters.Length == 2)
				{
					// services.AddScoped<global::Dummy.LoggingBehavior<,>>();
					// global::Dummy.LoggingBehavior<,>
					var constructorType = typeName.Replace("<,>", "<TRequest,TResponse>");
					return new Behavior
					{
						RegistrationType = typeName,
						ConstructorType = constructorType,
						RequestType = null,
						ResponseType = null,
					};
				}
				else
				{
					var constraint = GetConstraintInfo(symbol);

					return new Behavior
					{
						RegistrationType = typeName,
						ConstructorType = constraint.ConstructorType,
						RequestType = constraint.RequestType,
						ResponseType = constraint.ResponseType,
					};
				}
			})
			.ToArray();

		cancellationToken.ThrowIfCancellationRequested();
		return ImmutableArray.Create(behaviors);
	}

	private struct ConstraintInfo
	{
		public required string ConstructorType { get; set; }
		public string RequestType { get; set; }
		public string ResponseType { get; set; }
	}

	private static ConstraintInfo GetConstraintInfo(INamedTypeSymbol symbol)
	{
		// TODO: 
		// 1. figure out TRequest and TResponse
		// 2. figure out if type is bounded on either side
		throw new NotImplementedException();
	}

	private static void RenderServiceCollectionExtension(SourceProductionContext context, ImmutableArray<string?> handlers, ImmutableArray<Behavior?> behaviors, bool hasDi)
	{
		var cancellationToken = context.CancellationToken;
		cancellationToken.ThrowIfCancellationRequested();

		if (!hasDi)
			return;

		if (handlers.Any(h => h is null))
			return;

		if (behaviors.Any(b => b is null))
			return;

		cancellationToken.ThrowIfCancellationRequested();
		var template = GetTemplate("ServiceCollectionExtensions");

		cancellationToken.ThrowIfCancellationRequested();
		var source = template.Render(new
		{
			Handlers = handlers,
			Behaviors = behaviors,
		});

		cancellationToken.ThrowIfCancellationRequested();
		context.AddSource("Immediate.Handlers.ServiceCollectionExtensions.cs", source);
	}

	private static Handler? TransformHandler(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	)
	{
		var symbol = (INamedTypeSymbol)context.TargetSymbol;

		var @namespace = symbol.ContainingNamespace.ToString();
		var name = symbol.Name;
		var displayName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

		if (symbol
				.GetMembers()
				.OfType<IMethodSymbol>()
				.FirstOrDefault(m =>
					m.Name.Equals("Handle", StringComparison.Ordinal)
					|| m.Name.Equals("HandleAsync", StringComparison.Ordinal)
				) is not { } handleMethod)
		{
			return null;
		}

		// must have request type and cancellationtoken
		if (handleMethod.Parameters.Length < 2)
			return null;

		var requestType = BuildGenericType((INamedTypeSymbol)handleMethod.Parameters[0].Type);

		var responseTypeSymbol = handleMethod.GetTaskReturnType();
		if (responseTypeSymbol is null)
			return null;

		var responseType = BuildGenericType((INamedTypeSymbol)responseTypeSymbol);

		var parameters = handleMethod.Parameters
			.Skip(1).Take(handleMethod.Parameters.Length - 2)
			.Select(p => new Parameter
			{
				Type = p.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
				Name = p.Name,
			})
			.ToEquatableReadOnlyList();

		return new()
		{
			Namespace = @namespace,
			ClassName = name,
			DisplayName = displayName,

			RequestType = requestType,
			ResponseType = responseType,

			Parameters = parameters,
		};
	}

	private static GenericType BuildGenericType(INamedTypeSymbol type)
	{
		var name = type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

		var implements = new List<string>();
		AddBaseTypes(type, implements);

		return new()
		{
			Name = name,
			Implements = implements.Distinct().ToEquatableReadOnlyList(),
		};
	}

	private static void AddBaseTypes(ITypeSymbol type, List<string> implements)
	{
		if (type.OriginalDefinition.ToString() is
				"object"
				or "System.Collections.IEnumerable"
				or "System.IEquatable<T>"
		)
		{
			return;
		}

		implements.Add(type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat));
		if (type.BaseType is not null)
			AddBaseTypes(type.BaseType, implements);

		foreach (var i in type.Interfaces)
			AddBaseTypes(i, implements);
	}

	private static void RenderHandler(
		SourceProductionContext context,
		Handler? handler,
		ImmutableArray<Behavior?> behaviors,
		ImmutableArray<RenderMode> renderModes,
		bool hasMsDi,
		Template template
	)
	{
		if (handler == null)
			return;

		if (behaviors.Any(b => b is null))
			return;

		if (renderModes.Length > 1)
			return;

		var cancellationToken = context.CancellationToken;
		cancellationToken.ThrowIfCancellationRequested();

		var renderMode = renderModes.Length == 0 ? RenderMode.Normal : renderModes[0];
		// Only support normal render mode for now
		if (renderMode is not RenderMode.Normal)
		{
			return;
		}

		var handlerSource = template.Render(new
		{
			ClassFullyQualifiedName = handler.DisplayName,
			ClassName = handler.ClassName,
			hasMsDi = hasMsDi,
			Namespace = handler.Namespace,
			RequestType = handler.RequestType.Name,
			ResponseType = handler.ResponseType.Name,
		});

		cancellationToken.ThrowIfCancellationRequested();
		context.AddSource($"Immediate.Handlers.Templates.{handler.Namespace}.{handler.ClassName}.cs", handlerSource);
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
