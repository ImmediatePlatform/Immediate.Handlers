using Immediate.Handlers.CodeFixes;

namespace Immediate.Handlers.Tests.CodeFixTests;

public sealed class StaticToSealedHandlerRefactoringProviderTests
{
	[Test]
	public async Task RefactorOnHandlerClass() =>
		await CodeRefactoringTestHelper.CreateCodeRefactoringTest<StaticToSealedHandlerRefactoringProvider>(
			"""
			using System.Threading;
			using System.Threading.Tasks;

			namespace Immediate.Handlers.Shared;

			public sealed class Dependency1;
			public sealed class Dependency2;
			
			[Handler]
			public static partial class {|Refactoring:DoSomething|}
			{
				public sealed record Query;
				public sealed record Response;

				private static ValueTask<Response> HandleAsync(
					Query query,
					Dependency1 dependency1,
					Dependency2 dependency2,
					CancellationToken token
				)
				{
					Method(dependency2, 2);
					return new();
				}

				private static void Method(Dependency2 dependency2, int value)
				{
				}
			}
			""",
			"""
			using System.Threading;
			using System.Threading.Tasks;
			
			namespace Immediate.Handlers.Shared;
			
			public sealed class Dependency1;
			public sealed class Dependency2;
			
			[Handler]
			public sealed partial class DoSomething(Dependency1 dependency1, Dependency2 dependency2)
			{
				public sealed record Query;
				public sealed record Response;
			
				private ValueTask<Response> HandleAsync(
					Query query,
					CancellationToken token
				)
				{
					Method(dependency2, 2);
					return new();
				}
			
				private static void Method(Dependency2 dependency2, int value)
				{
				}
			}
			"""
		).RunAsync();

	[Test]
	public async Task RefactorOnHandlerMethod() =>
		await CodeRefactoringTestHelper.CreateCodeRefactoringTest<StaticToSealedHandlerRefactoringProvider>(
			"""
			using System.Threading;
			using System.Threading.Tasks;

			namespace Immediate.Handlers.Shared;

			public sealed class Dependency1;
			public sealed class Dependency2;
			
			[Handler]
			public static partial class DoSomething
			{
				public sealed record Query;
				public sealed record Response;

				private static ValueTask<Response> {|Refactoring:HandleAsync|}(
					Query query,
					Dependency1 dependency1,
					Dependency2 dependency2,
					CancellationToken token
				)
				{
					Method(dependency2, 2);
					return new();
				}

				private static void Method(Dependency2 dependency2, int value)
				{
				}
			}
			""",
			"""
			using System.Threading;
			using System.Threading.Tasks;
			
			namespace Immediate.Handlers.Shared;
			
			public sealed class Dependency1;
			public sealed class Dependency2;
			
			[Handler]
			public sealed partial class DoSomething(Dependency1 dependency1, Dependency2 dependency2)
			{
				public sealed record Query;
				public sealed record Response;
			
				private ValueTask<Response> HandleAsync(
					Query query,
					CancellationToken token
				)
				{
					Method(dependency2, 2);
					return new();
				}
			
				private static void Method(Dependency2 dependency2, int value)
				{
				}
			}
			"""
		).RunAsync();

	[Test]
	public async Task RefactorWithNoDependencyParameters() =>
	await CodeRefactoringTestHelper.CreateCodeRefactoringTest<StaticToSealedHandlerRefactoringProvider>(
		"""
			using System.Threading;
			using System.Threading.Tasks;

			namespace Immediate.Handlers.Shared;

			[Handler]
			public static partial class {|Refactoring:DoSomething|}
			{
				public sealed record Query;
				public sealed record Response;

				private static ValueTask<Response> HandleAsync(
					Query query,
					CancellationToken token
				)
				{
					return new();
				}
			}
			""",
		"""
			using System.Threading;
			using System.Threading.Tasks;
			
			namespace Immediate.Handlers.Shared;
			
			[Handler]
			public sealed partial class DoSomething
			{
				public sealed record Query;
				public sealed record Response;
			
				private ValueTask<Response> HandleAsync(
					Query query,
					CancellationToken token
				)
				{
					return new();
				}
			}
			"""
	).RunAsync();
}
