using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Generators.ImmediateHandlers;
using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers.Tests.GeneratorTests;

public static class GeneratorTestHelper
{
	public static async Task<GeneratorDriverRunResult> RunGenerator(
		[StringSyntax("c#-test")] string source,
		DriverReferenceAssemblies assemblies
	)
	{
		var syntaxTree = CSharpSyntaxTree.ParseText(source);

		var compilation = CSharpCompilation.Create(
			assemblyName: "Tests",
			syntaxTrees: [syntaxTree],
			references:
			[
				.. Basic.Reference.Assemblies.Net80.References.All,
				.. assemblies.GetAdditionalReferences(),
			],
			options: new(
				outputKind: OutputKind.DynamicallyLinkedLibrary
			)
		);

		var generator = new ImmediateHandlersGenerator();

		var driver = CSharpGeneratorDriver
			.Create(generator)
			.RunGeneratorsAndUpdateCompilation(
				compilation,
				out var outputCompilation,
				out var diagnostics
			);

		_ = await Assert
			.That(
				outputCompilation
					.GetDiagnostics()
					.Where(d => d.Severity is DiagnosticSeverity.Error or DiagnosticSeverity.Warning)
			)
			.IsEmpty();

		_ = await Assert.That(diagnostics).IsEmpty();

		return driver.GetRunResult();
	}
}
