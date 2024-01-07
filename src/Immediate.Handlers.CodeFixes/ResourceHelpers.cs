using Microsoft.CodeAnalysis;

namespace Immediate.Handlers.CodeFixes;

public static class ResourceHelpers
{
	public static LocalizableResourceString GetResourceString(string name)
	{
		return new LocalizableResourceString(name, Resources.ResourceManager,
			typeof(Resources));
	}
}
