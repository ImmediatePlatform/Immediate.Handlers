using Immediate.Handlers.Shared;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Generators.ImmediateHandlers;

public partial class ImmediateHandlersGenerator
{
	private static EquatableReadOnlyList<Behavior?> TransformBehaviors(
		GeneratorAttributeSyntaxContext context,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var semanticModel = context.SemanticModel;
		var compilation = semanticModel.Compilation;
		cancellationToken.ThrowIfCancellationRequested();

		return ParseBehaviors(context.Attributes[0], compilation, cancellationToken);
	}

	private static EquatableReadOnlyList<Behavior?> ParseBehaviors(
		AttributeData attribute,
		Compilation compilation,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();
		var behaviorType = typeof(Behavior<,>);
		var behaviorTypeSymbol = compilation.GetTypeByMetadataName(behaviorType.FullName);
		if (behaviorTypeSymbol is null)
			return [];

		if (attribute.ConstructorArguments.Length != 1)
			return [];

		var ca = attribute.ConstructorArguments[0];
		var arrayTypeSymbol = compilation.CreateArrayTypeSymbol(
			compilation.GetTypeByMetadataName("System.Type")!, 1)!;
		if (!SymbolEqualityComparer.Default.Equals(
				ca.Type,
				arrayTypeSymbol
		))
		{
			return [];
		}

		cancellationToken.ThrowIfCancellationRequested();
		return ca.Values
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

				var nonGenericTypeName = symbol.OriginalDefinition.ToDisplayString(DisplayNameFormatters.NonGenericFqdnFormat);
				if (symbol.IsUnboundGenericType && symbol.TypeParameters.Length == 2)
				{
					// services.AddScoped<global::Dummy.LoggingBehavior<,>>();
					// global::Dummy.LoggingBehavior<,>
					var constructorType = typeName.Replace("<,>", "<TRequest,TResponse>");
					return new Behavior
					{
						RegistrationType = typeName,
						ConstructorType = constructorType,
						NonGenericTypeName = nonGenericTypeName,
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
						NonGenericTypeName = nonGenericTypeName,
						RequestType = constraint.RequestType,
						ResponseType = constraint.ResponseType,
					};
				}
			})
			.ToEquatableReadOnlyList();
	}

	private static ConstraintInfo GetConstraintInfo(INamedTypeSymbol symbol)
	{
		// TODO: 
		// 1. figure out TRequest and TResponse
		// 2. figure out if type is bounded on either side
		throw new NotImplementedException();
	}
}
