using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class BehaviorsAnalyzer : DiagnosticAnalyzer
{
	private static readonly DiagnosticDescriptor BehaviorsMustInheritFromBehavior =
		new(
			id: DiagnosticIds.IHR0006BehaviorsMustInheritFromBehavior,
			title: "Behaviors must inherit from Behavior<,>",
			messageFormat: "Behavior '{0}' must inherit from Behavior<,>",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All behaviors must inherit from Behavior<,> in order to be used properly."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create<DiagnosticDescriptor>(
			[
				BehaviorsMustInheritFromBehavior,
			]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterOperationAction(AnalyzeOperation, OperationKind.Attribute);
	}

	private void AnalyzeOperation(OperationAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		if (context.Operation is not IAttributeOperation { Operation: IObjectCreationOperation attribute })
			return;

		var behaviorsAttributeSymbol = context.Compilation.GetTypeByMetadataName("Immediate.Handlers.Shared.BehaviorsAttribute");

		token.ThrowIfCancellationRequested();
		if (!SymbolEqualityComparer.Default.Equals(attribute.Type?.OriginalDefinition, behaviorsAttributeSymbol))
			return;

		if (attribute.Arguments.Length != 1)
		{
			// note: this will already be a compiler error anyway
			return;
		}

		token.ThrowIfCancellationRequested();
		var array = attribute.Arguments[0].Value;

		var compilation = context.Compilation;
		var arrayTypeSymbol = compilation.CreateArrayTypeSymbol(compilation.GetTypeByMetadataName("System.Type")!, 1);
		if (array is null
			|| !SymbolEqualityComparer.Default.Equals(array.Type, arrayTypeSymbol)
			|| array.ChildOperations.Count != 2
			|| array.ChildOperations.ElementAt(1) is not IArrayInitializerOperation aio)
		{
			// note: this will already be a compiler error anyway
			return;
		}

		foreach (var op in aio.ChildOperations)
		{
			token.ThrowIfCancellationRequested();
			if (op is not ITypeOfOperation { TypeOperand: INamedTypeSymbol behaviorType, })
				continue;

			_ = behaviorType.ToString();
		}
	}
}
