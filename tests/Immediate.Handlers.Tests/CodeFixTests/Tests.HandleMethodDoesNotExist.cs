using Immediate.Handlers.Analyzers;
using Immediate.Handlers.CodeFixes;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.CodeFixTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Test]
	public async Task HandleMethodDoesNotExist() =>
		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerMethodMustExistCodeFixProvider>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public static class {|IHR0001:GetUsersQuery|}
			{
				public record Query;
			}
			""",
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			[Handler]
			public static class GetUsersQuery
			{
				public record Query;

				private static ValueTask<int> HandleAsync(Query _, CancellationToken token)
				{
					return default;
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync();
}
