using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Tests.Helpers;

public static class ReferenceAssemblyHelpers
{
	public static IEnumerable<MetadataReference> GetReferences(this DriverReferenceAssemblies assemblies)
	{
		ArgumentNullException.ThrowIfNull(assemblies);

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
				MetadataReference.CreateFromFile("./Microsoft.Extensions.DependencyInjection.Abstractions.dll"),
			]
		);

		if (assemblies is DriverReferenceAssemblies.Msdi)
			return references;

		// to be done with other renderers
		throw new NotImplementedException();
	}
}

public enum DriverReferenceAssemblies
{
	Normal,
	Msdi,
}
