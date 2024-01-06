using System.Runtime.CompilerServices;

namespace Immediate.Handlers.Tests;

public static class ModuleInitializer
{
	[ModuleInitializer]
	public static void Init()
	{
		VerifySourceGenerators.Initialize();
		VerifyDiffPlex.Initialize();
	}
}
