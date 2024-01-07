// using System.Collections.Immutable;
// using Microsoft.CodeAnalysis;
// using Microsoft.CodeAnalysis.CSharp;
// using Microsoft.CodeAnalysis.CSharp.Syntax;
// using Microsoft.CodeAnalysis.Diagnostics;
//
// namespace Immediate.Handlers.Analyzers;
//
// /// <summary>
// /// A sample analyzer that reports the company name being used in class declarations.
// /// Traverses through the Syntax Tree and checks the name (identifier) of each class node.
// /// </summary>
// [DiagnosticAnalyzer(LanguageNames.CSharp)]
// public class SampleSyntaxAnalyzer : DiagnosticAnalyzer
// {
// 	// Keep in mind: you have to list your rules here.
// 	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
// 		ImmutableArray.Create(Rule);
//
// 	public override void Initialize(AnalysisContext context)
// 	{
// 		// You must call this method to avoid analyzing generated code.
// 		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
//
// 		// You must call this method to enable the Concurrent Execution.
// 		context.EnableConcurrentExecution();
//
// 		// Subscribe to the Syntax Node with the appropriate 'SyntaxKind' (ClassDeclaration) action.
// 		// To figure out which Syntax Nodes you should choose, consider installing the Roslyn syntax tree viewer plugin Rossynt: https://plugins.jetbrains.com/plugin/16902-rossynt/
// 		context.RegisterSyntaxNodeAction(AnalyzeSyntax, SyntaxKind.ClassDeclaration);
//
// 		// Check other 'context.Register...' methods that might be helpful for your purposes.
// 	}
//
// 	/// <summary>
// 	/// Executed for each Syntax Node with 'SyntaxKind' is 'ClassDeclaration'.
// 	/// </summary>
// 	/// <param name="context">Operation context.</param>
// 	private void AnalyzeSyntax(SyntaxNodeAnalysisContext context)
// 	{
// 		// The Roslyn architecture is based on inheritance.
// 		// To get the required metadata, we should match the 'Node' object to the particular type: 'ClassDeclarationSyntax'.
// 		if (context.Node is not ClassDeclarationSyntax classDeclarationNode)
// 			return;
//
// 		// 'Identifier' means the token of the node. In this case, the identifier of the 'ClassDeclarationNode' is the class name.
// 		var classDeclarationIdentifier = classDeclarationNode.Identifier;
//
// 		// Find class symbols whose name contains the company name.
// 		if (classDeclarationIdentifier.Text.Contains(CompanyName))
// 		{
// 			var diagnostic = Diagnostic.Create(Rule,
// 				// The highlighted area in the analyzed source code. Keep it as specific as possible.
// 				classDeclarationIdentifier.GetLocation(),
// 				// The value is passed to 'MessageFormat' argument of your 'Rule'.
// 				classDeclarationIdentifier.Text);
//
// 			// Reporting a diagnostic is the primary outcome of the analyzer.
// 			context.ReportDiagnostic(diagnostic);
// 		}
// 	}
// }
