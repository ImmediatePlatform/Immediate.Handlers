using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Tests.Helpers;

public static class ReferenceAssemblyHelpers
{
	public static List<MetadataReference> GetReferences(this ICollection<DriverReferenceAssemblies> assemblies)
	{
		ArgumentNullException.ThrowIfNull(assemblies);

		List<MetadataReference> references = [];

		if (assemblies.Contains(DriverReferenceAssemblies.Normal))
		{
			references.AddRange([
				.. Basic.Reference.Assemblies.NetStandard20.References.All,
				MetadataReference.CreateFromFile("./Immediate.Handlers.Shared.dll")
			]);
		}

		if (assemblies.Contains(DriverReferenceAssemblies.Msdi))
		{
			references.AddRange(
				[
					MetadataReference.CreateFromFile("./Microsoft.Extensions.DependencyInjection.dll"),
					MetadataReference.CreateFromFile("./Microsoft.Extensions.DependencyInjection.Abstractions.dll")
				]
			);
		}

		return references;
	}
}

public enum DriverReferenceAssemblies
{
	Normal,
	Msdi,
}