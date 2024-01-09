namespace Immediate.Handlers.Analyzers;

public static class DiagnosticIds
{
	public const string IHR0001HandlerMethodMustExist = "IHR0001";
	public const string IHR0002HandlerMethodMustReturnTask = "IHR0002";
	public const string IHR0003HandlerMethodMustReceiveCorrectParameters = "IHR0003";
	public const string IHR0004InvalidRenderMode = "IHR0004";
	public const string IHR0005HandlerClassMustNotBeNested = "IHR0005";
	public const string IHR0006BehaviorsMustInheritFromBehavior = "IHR0006";
	public const string IHR0007BehaviorsMustHaveTwoGenericParameters = "IHR0007";
	public const string IHR0008BehaviorsMustNotInheritFromBoundedBehaviour = "IHR0008";
}
