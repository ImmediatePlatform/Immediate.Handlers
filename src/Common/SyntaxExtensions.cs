using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Immediate.Handlers;

internal static class SyntaxExtensions
{
	public static bool IsCancellationToken(this SemanticModel model, TypeSyntax? typeSyntax, CancellationToken token) =>
		typeSyntax is { } syntax
		&& model.GetSymbolInfo(syntax, token).Symbol is INamedTypeSymbol namedType
		&& namedType.IsCancellationToken();
}
