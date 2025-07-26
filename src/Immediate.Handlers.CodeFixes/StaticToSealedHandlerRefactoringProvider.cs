using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeRefactorings;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Immediate.Handlers.CodeFixes;

[ExportCodeRefactoringProvider(LanguageNames.CSharp, Name = "Convert to instance handler")]
public sealed class StaticToSealedHandlerRefactoringProvider : CodeRefactoringProvider
{
	public override async Task ComputeRefactoringsAsync(CodeRefactoringContext context)
	{
		var (document, span, token) = context;
		token.ThrowIfCancellationRequested();

		if (await document.GetRequiredSyntaxRootAsync(token) is not CompilationUnitSyntax root)
			return;

		var model = await document.GetRequiredSemanticModelAsync(token);

		switch (root.FindNode(span))
		{
			case TypeDeclarationSyntax tds:
			{
				if (model.GetDeclaredSymbol(tds, token) is not INamedTypeSymbol { IsStatic: true } container)
					return;

				if (!container.GetAttributes().Any(a => a.AttributeClass.IsHandlerAttribute()))
					return;

				var method = container.GetMembers()
					.OfType<IMethodSymbol>()
					.FirstOrDefault(m => m is { IsStatic: true, Name: "Handle" or "HandleAsync" });

				if (method is null)
					return;

				context.RegisterRefactoring(
					CodeAction.Create(
						title: "Convert to instance handler",
						createChangedDocument: token => ConvertToInstanceHandler(
							context.Document,
							root,
							container,
							method,
							token
						),
						equivalenceKey: nameof(StaticToSealedHandlerRefactoringProvider)
					)
				);

				break;
			}

			case MethodDeclarationSyntax mds:
			{
				if (model.GetDeclaredSymbol(mds, token) is not IMethodSymbol { IsStatic: true, Name: "Handle" or "HandleAsync" } method)
					return;

				var container = method.ContainingType;

				if (!container.GetAttributes().Any(a => a.AttributeClass.IsHandlerAttribute()))
					return;

				context.RegisterRefactoring(
					CodeAction.Create(
						title: "Convert to instance handler",
						createChangedDocument: token => ConvertToInstanceHandler(
							context.Document,
							root,
							container,
							method,
							token
						),
						equivalenceKey: nameof(StaticToSealedHandlerRefactoringProvider)
					)
				);

				break;
			}

			default:
				break;
		}
	}

	private async Task<Document> ConvertToInstanceHandler(
		Document document,
		CompilationUnitSyntax root,
		INamedTypeSymbol container,
		IMethodSymbol method,
		CancellationToken token
	)
	{
		var model = await document.GetRequiredSemanticModelAsync(token);

		var methodDeclaration = (MethodDeclarationSyntax)await method
			.DeclaringSyntaxReferences
			.First()
			.GetSyntaxAsync(token);

		var methodParameters = methodDeclaration.ParameterList.Parameters;
		var classParameters = new List<ParameterSyntax>();

		foreach (var parameter in methodParameters.ToList().Skip(1))
		{
			token.ThrowIfCancellationRequested();

			if (parameter.Type is null)
				return document;

			if ((model.GetSymbolInfo(parameter.Type, token).Symbol as INamedTypeSymbol).IsCancellationToken())
				continue;

			methodParameters = methodParameters.Remove(parameter);
			classParameters.Add(parameter);


		}

		var newMethodDeclaration = methodDeclaration
			.WithParameterList(
				ParameterList(SeparatedList(methodParameters))
			)
			.WithModifiers(
				methodDeclaration.Modifiers
					.Remove(Token(SyntaxKind.StaticKeyword))
			);

		return document;
	}
}

