using System.Diagnostics.CodeAnalysis;

namespace Immediate.Handlers.Analyzers;

[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Diagnostic IDs start with IHR")]
internal static class DiagnosticIds
{
	public const string IHR0001HandlerMethodMustExist = "IHR0001";
	public const string IHR0002HandlerMethodMustReturnTask = "IHR0002";
	public const string IHR0005HandlerClassMustNotBeNested = "IHR0005";
	public const string IHR0006BehaviorsMustInheritFromBehavior = "IHR0006";
	public const string IHR0007BehaviorsMustHaveTwoGenericParameters = "IHR0007";
	public const string IHR0008BehaviorsMustUseUnboundGenerics = "IHR0008";
	public const string IHR0010HandlerMethodMustBeUnique = "IHR0010";
	public const string IHR0011HandlerMethodMustBePrivate = "IHR0011";
	public const string IHR0012HandlerShouldUseCancellationToken = "IHR0012";
	public const string IHR0013IHandlerMissingImplementation = "IHR0013";
	public const string IHR0014HandlerMethodMissingRequest = "IHR0014";
	public const string IHR0015HandlerMethodHasTooManyParameters = "IHR0015";
	public const string IHR0016ContainingClassMustBeSealed = "IHR0016";
	public const string IHR0017ContainingClassInstanceMembersMustBePrivate = "IHR0017";
	public const string IHR0018ContainingClassMustBeStatic = "IHR0018";
	public const string IHR0019StaticHandlerCouldBeSealed = "IHR0019";
	public const string IHR0020BehaviorHasIncorrectTypeArgument = "IHR0020";
	public const string IHR0021BehaviorClassUsesInvalidConstraints = "IHR0021";
}
