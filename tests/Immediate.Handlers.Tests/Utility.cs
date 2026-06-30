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
			"11.0.0-preview.5.26302.115"
		),
		Path.Combine("ref", "net11.0")
	);
	public static IEnumerable<MetadataReference> NetCoreAssemblies => Basic.Reference.Assemblies.Net110.References.All;
#else
#error .net version not yet implemented
#endif

	public static IEnumerable<MetadataReference> GetAdditionalReferences() =>
	[
		MetadataReference.CreateFromFile(typeof(HandlerAttribute).Assembly.Location),
		MetadataReference.CreateFromFile(typeof(ServiceCollection).Assembly.Location),
		MetadataReference.CreateFromFile(typeof(IServiceCollection).Assembly.Location),
	];
}
