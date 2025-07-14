using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Generators;
using Immediate.Handlers.Tests.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers.Tests.GeneratorTests;

public static class GeneratorTestHelper
{
	public static GeneratorDriverRunResult RunGenerator(
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

		var clone = compilation.Clone().AddSyntaxTrees(CSharpSyntaxTree.ParseText("// dummy"));

		GeneratorDriver driver = CSharpGeneratorDriver.Create(
			generators: [new ImmediateHandlersGenerator().AsSourceGenerator()],
			driverOptions: new GeneratorDriverOptions(default, trackIncrementalGeneratorSteps: true)
		);

		var result1 = RunGenerator(ref driver, compilation);
		var result2 = RunGenerator(ref driver, clone);

		foreach (var (_, step) in result2.Results[0].TrackedOutputSteps)
			AssertSteps(step);

		foreach (var step in TrackedSteps)
		{
			if (result2.Results[0].TrackedSteps.TryGetValue(step, out var outputs))
				AssertSteps(outputs);
		}

		return result1;
	}

	private static GeneratorDriverRunResult RunGenerator(
		ref GeneratorDriver driver,
		Compilation compilation
	)
	{
		driver = driver
			.RunGeneratorsAndUpdateCompilation(
				compilation,
				out var outputCompilation,
				out var diagnostics
			);

		Assert.Empty(
			outputCompilation
				.GetDiagnostics()
				.Where(d => d.Severity is DiagnosticSeverity.Error or DiagnosticSeverity.Warning)
		);

		Assert.Empty(diagnostics);
		return driver.GetRunResult();
	}

	private static ReadOnlySpan<string> TrackedSteps =>
		new string[]
		{
			"MsDi",
			"AssemblyName",
			"RootNamespace",
			"Behaviors",
			"Handlers",
			"HandlersWithBehaviors",
			"Registrations",
		};

	private static void AssertSteps(
		ImmutableArray<IncrementalGeneratorRunStep> steps
	)
	{
		var outputs = steps.SelectMany(o => o.Outputs);

		Assert.All(outputs, o => Assert.True(o.Reason is IncrementalStepRunReason.Unchanged or IncrementalStepRunReason.Cached));
	}
}
