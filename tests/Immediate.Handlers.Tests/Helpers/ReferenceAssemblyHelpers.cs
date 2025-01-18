using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Tests.Helpers;

public static class ReferenceAssemblyHelpers
{
	public static IEnumerable<MetadataReference> GetAdditionalReferences(this DriverReferenceAssemblies assemblies)
	{
		List<MetadataReference> references =
		[
			MetadataReference.CreateFromFile("./Immediate.Handlers.Shared.dll"),
		];

		if (assemblies is DriverReferenceAssemblies.Normal)
			return references;

		references.AddRange(
			[
				MetadataReference.CreateFromFile("./Microsoft.Extensions.DependencyInjection.dll"),
				MetadataReference.CreateFromFile("./Microsoft.Extensions.DependencyInjection.Abstractions.dll"),
			]
		);

		if (assemblies is DriverReferenceAssemblies.Msdi)
			return references;

		// to be done with other renderers
		throw new UnreachableException();
	}
}

public enum DriverReferenceAssemblies
{
	None = 0,
	Normal,
	Msdi,
}
