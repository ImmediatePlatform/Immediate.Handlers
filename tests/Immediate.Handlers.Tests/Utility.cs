using System.Diagnostics;
using System.Reflection;
using Immediate.Handlers.Shared;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Immediate.Handlers.Tests;

public static class Utility
{
#if NET8_0
	public static ReferenceAssemblies ReferenceAssemblies => ReferenceAssemblies.Net.Net80;
	public static IEnumerable<MetadataReference> NetCoreAssemblies => Basic.Reference.Assemblies.Net80.References.All;
#elif NET9_0
	public static ReferenceAssemblies ReferenceAssemblies => ReferenceAssemblies.Net.Net90;
	public static IEnumerable<MetadataReference> NetCoreAssemblies => Basic.Reference.Assemblies.Net90.References.All;
#elif NET10_0
	public static ReferenceAssemblies ReferenceAssemblies => ReferenceAssemblies.Net.Net100;
	public static IEnumerable<MetadataReference> NetCoreAssemblies => Basic.Reference.Assemblies.Net100.References.All;
#elif NET11_0
	public static ReferenceAssemblies ReferenceAssemblies { get; } = new ReferenceAssemblies(
		"net11.0",
		new PackageIdentity(
			"Microsoft.NETCore.App.Ref",
			"11.0.0-preview.3.26207.106"
		),
		Path.Combine("ref", "net11.0")
	);
	public static IEnumerable<MetadataReference> NetCoreAssemblies => Basic.Reference.Assemblies.Net110.References.All;
#else
#error .net version not yet implemented
#endif

	public static IEnumerable<MetadataReference> GetAdditionalReferences(this DriverReferenceAssemblies assemblies) =>
		assemblies switch
		{
			DriverReferenceAssemblies.Normal =>
			[
				MetadataReference.CreateFromFile(GetAssemblyLocation(typeof(HandlerAttribute))),
			],

			DriverReferenceAssemblies.Msdi =>
			[
				MetadataReference.CreateFromFile(GetAssemblyLocation(typeof(HandlerAttribute))),
				MetadataReference.CreateFromFile(GetAssemblyLocation(typeof(ServiceCollection))),
				MetadataReference.CreateFromFile(GetAssemblyLocation(typeof(IServiceCollection))),
			],

			DriverReferenceAssemblies.None or _ => throw new UnreachableException(),
		};

	private static string GetAssemblyLocation(this Type type)
	{
		if (Assembly.GetAssembly(type) is not { Location: { } location })
			throw new InvalidOperationException("Missing assembly");

		return location;
	}
}

public enum DriverReferenceAssemblies
{
	None = 0,
	Normal,
	Msdi,
}
