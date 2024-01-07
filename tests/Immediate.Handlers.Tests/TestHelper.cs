using Immediate.Handlers.Generators.ImmediateHandlers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Immediate.Handlers.Tests;

public static class TestHelper
{
	public static GeneratorDriver GetDriver(string source, DriverReferenceAssemblies assemblies = DriverReferenceAssemblies.Normal)
	{
		// Parse the provided string into a C# syntax tree
		var syntaxTree = CSharpSyntaxTree.ParseText(source);

		// Create a Roslyn compilation for the syntax tree.
		var compilation = CSharpCompilation.Create(
			assemblyName: "Tests",
			syntaxTrees: new[] { syntaxTree },
			references: GetReferences(assemblies)
		);

		// Create an instance of our incremental source generator
		var generator = new ImmediateHandlersGenerator();

		// The GeneratorDriver is used to run our generator against a compilation
		GeneratorDriver driver = CSharpGeneratorDriver.Create(generator);

		// Run the source generator!
		return driver.RunGenerators(compilation);
	}

	private static List<MetadataReference> GetReferences(DriverReferenceAssemblies assemblies)
	{
		List<MetadataReference> references =
		[
			.. Basic.Reference.Assemblies.NetStandard20.References.All,
			MetadataReference.CreateFromFile("./Immediate.Handlers.Shared.dll"),
		];

		if (assemblies is DriverReferenceAssemblies.Normal)
			return references;

		references.AddRange(
			[
				MetadataReference.CreateFromFile("./Microsoft.Extensions.DependencyInjection.dll"),
				MetadataReference.CreateFromFile("./Microsoft.Extensions.DependencyInjection.Abstractions.dll")
			]
		);

		if (assemblies is DriverReferenceAssemblies.Msdi)
			return references;

		// for mvc+
		throw new NotImplementedException();
	}
}

public enum DriverReferenceAssemblies
{
	Normal,
	Msdi,
}
