using Immediate.Handlers.Shared;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators.ImmediateHandlers;

public partial class ImmediateHandlersGenerator
{
	private RenderMode TransformRenderMode(GeneratorAttributeSyntaxContext context, CancellationToken token)
		=> ParseRenderMode(context.Attributes[0]);

	private static RenderMode ParseRenderMode(AttributeData attr)
	{
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
}
