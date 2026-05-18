using System.Runtime.CompilerServices;

namespace Immediate.Handlers.Tests;

public static class ModuleInitializer
{
	[ModuleInitializer]
	public static void Init()
	{
		VerifierSettings.AutoVerify(includeBuildServer: false);
		VerifierSettings.ScrubLinesContaining("cs", comparison: StringComparison.Ordinal, "GeneratedCodeAttribute");
		UseSourceFileRelativeDirectory("Snapshots");

		VerifySourceGenerators.Initialize();
	}
}
