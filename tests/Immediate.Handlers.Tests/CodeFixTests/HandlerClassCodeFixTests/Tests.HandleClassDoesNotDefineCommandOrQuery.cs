using Immediate.Handlers.Analyzers;
using Immediate.Handlers.CodeFixes;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.CodeFixTests.HandlerClassCodeFixTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Fact]
	public async Task HandleClassDoesNotDefineCommandOrQuery_AddsQuery() =>
		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerClassMustDefineCommandOrQueryCodeFixProvider>(
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
			public static class {|IHR0009:GetUsersQuery|}
			{
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
			public static class {|IHR0001:GetUsersQuery|}
			{
				public record Query;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync();

	[Fact]
	public async Task HandleClassDoesNotDefineCommandOrQuery_AddsCommand() =>
		await CodeFixTestHelper.CreateCodeFixTest<HandlerClassAnalyzer, HandlerClassMustDefineCommandOrQueryCodeFixProvider>(
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
			public static class {|IHR0009:GetUsersQuery|}
			{
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
			public static class {|IHR0001:GetUsersQuery|}
			{
				public record Command;
			}
			""",
			DriverReferenceAssemblies.Normal,
			1
		).RunAsync();
}
