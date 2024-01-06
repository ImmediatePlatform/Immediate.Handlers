using Immediate.Handlers.Generators;
using Immediate.Handlers.Shared;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers.Tests;

public static class TestHelper
{
	public static GeneratorDriver GetDriver(string source)
	{
		// Parse the provided string into a C# syntax tree
		var syntaxTree = CSharpSyntaxTree.ParseText(source);

		// Create a Roslyn compilation for the syntax tree.
		var compilation = CSharpCompilation.Create(
			assemblyName: "Tests",
			syntaxTrees: new[] { syntaxTree },
			references: [MetadataReference.CreateFromFile("./Immediate.Handlers.Shared.dll")]);

		// Create an instance of our incremental source generator
		var generator = new ImmediateHandlersGenerator();

		// The GeneratorDriver is used to run our generator against a compilation
		GeneratorDriver driver = CSharpGeneratorDriver.Create(generator);

		// Run the source generator!
		return driver.RunGenerators(compilation);
	}
}