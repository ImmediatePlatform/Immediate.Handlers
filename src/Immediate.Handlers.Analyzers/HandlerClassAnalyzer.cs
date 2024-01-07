using System.Collections.Immutable;
using Immediate.Handlers.Analyzers.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

/// <summary>
/// A sample analyzer that reports invalid values being used for the 'speed' parameter of the 'SetSpeed' function.
/// To make sure that we analyze the method of the specific class, we use semantic analysis instead of the syntax tree, so this analyzer will not work if the project is not compilable.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class HandlerClassAnalyzer : DiagnosticAnalyzer
{
	// Keep in mind: you have to list your rules here.
	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(HandlerMethodDoesMustExistDiagnostic.Rule, HandlerMethodMustReturnTaskTDiagnostic.Rule, HandlerMethodMustDeclareTwoParametersDiagnostic.Rule);

	public override void Initialize(AnalysisContext context)
	{
		// You must call this method to avoid analyzing generated code.
		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

		// You must call this method to enable the Concurrent Execution.
		context.EnableConcurrentExecution();

		// Subscribe to semantic (compile time) action invocation, e.g. method invocation.
		context.RegisterSymbolAction(AnalyzeSymbol, SymbolKind.NamedType);
	}

	private void AnalyzeSymbol(SymbolAnalysisContext context)
	{
		if (context.Symbol is not INamedTypeSymbol namedTypeSymbol)
			return;

		if (namedTypeSymbol.GetAttributes().All(x => x.AttributeClass?.ToString() != "Immediate.Handlers.Shared.HandlerAttribute"))
			return;

		var method = namedTypeSymbol.GetMembers().FirstOrDefault(x => x.Name == "HandleAsync");

		if (method == null)
		{
			var doesNotExistDiagnostic = Diagnostic.Create(HandlerMethodDoesMustExistDiagnostic.Rule,
				namedTypeSymbol.Locations[0],
				namedTypeSymbol.Name);

			context.ReportDiagnostic(doesNotExistDiagnostic);
			return;
		}

		if (method is not IMethodSymbol methodSymbol)
			return;

		if (methodSymbol.ReturnType is INamedTypeSymbol returnTypeSymbol &&
			returnTypeSymbol.ConstructedFrom.ToString() is not "System.Threading.Tasks.Task<TResult>")
		{
			var mustReturnTaskT = Diagnostic.Create(HandlerMethodMustReturnTaskTDiagnostic.Rule,
				methodSymbol.Locations[0],
				methodSymbol.Name);

			context.ReportDiagnostic(mustReturnTaskT);
			return;
		}

		var methodSymbolParams = methodSymbol.Parameters;
		if (methodSymbolParams.Length < 2 ||
			methodSymbolParams[0].Type.ToString().Split().Last() is not ("Query" or "Command") ||
			methodSymbolParams.Last().Type.ToString() is not "System.Threading.CancellationToken")
		{
			var mustHaveTwoParameters = Diagnostic.Create(HandlerMethodMustDeclareTwoParametersDiagnostic.Rule,
				methodSymbol.Locations[0],
				methodSymbol.Name);

			context.ReportDiagnostic(mustHaveTwoParameters);
		}


	}

	// /// <summary>
	// /// Executed on the completion of the semantic analysis associated with the Invocation operation.
	// /// </summary>
	// /// <param name="context">Operation context.</param>
	// private void AnalyzeOperation(OperationAnalysisContext context)
	// {
	// 	// The Roslyn architecture is based on inheritance.
	// 	// To get the required metadata, we should match the 'Operation' and 'Syntax' objects to the particular types,
	// 	// which are based on the 'OperationKind' parameter specified in the 'Register...' method.
	// 	if (context.Operation is not IInvocationOperation invocationOperation ||
	// 	    context.Operation.Syntax is not InvocationExpressionSyntax invocationSyntax)
	// 		return;
	//
	// 	var methodSymbol = invocationOperation.TargetMethod;
	//
	// 	// Check whether the method name is 'SetSpeed' and it is a member of the 'Spaceship' class.
	// 	if (methodSymbol.MethodKind != MethodKind.Ordinary ||
	// 	    methodSymbol.ReceiverType?.Name != CommonApiClassName ||
	// 	    methodSymbol.Name != CommonApiMethodName
	// 	   )
	// 		return;
	//
	// 	// Count validation is enough in most cases. Keep analyzers as simple as possible.
	// 	if (invocationSyntax.ArgumentList.Arguments.Count != 1)
	// 		return;
	//
	// 	// Traverse through the syntax tree, starting with the particular 'InvocationSyntax' to the desired node.
	// 	var argumentSyntax = invocationSyntax.ArgumentList.Arguments.Single().Expression;
	//
	// 	// The 'ToString' method of 'Syntax' classes returns the corresponding part of the source code.
	// 	var argument = argumentSyntax.ToString();
	//
	// 	if (!int.TryParse(argument, out var actualSpeed))
	// 		return;
	//
	// 	if (actualSpeed <= 299_792_458)
	// 		return;
	//
	// 	var diagnostic = Diagnostic.Create(Rule,
	// 		// The highlighted area in the analyzed source code. Keep it as specific as possible.
	// 		argumentSyntax.GetLocation(),
	// 		// The value is passed to the 'MessageFormat' argument of your rule.
	// 		actualSpeed);
	//
	// 	// Reporting a diagnostic is the primary outcome of analyzers.
	// 	context.ReportDiagnostic(diagnostic);
	// }
}
