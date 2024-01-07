using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.Analyzers;

public static class ResourceHelpers
{
	public static LocalizableResourceString GetResourceString(string name)
	{
		return new LocalizableResourceString(name, Resources.ResourceManager,
			typeof(Resources));
	}
}
