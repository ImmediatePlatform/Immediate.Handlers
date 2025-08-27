using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Not being consumed by other code")]
public partial class Tests
{
	[Fact]
	public async Task HandleMethodWithZeroParameters_Static_AlertDiagnostic() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
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
			public static partial class {|IHR0019:GetUsersQuery|}
			{
				public record Query;
			
				private static ValueTask<int> {|IHR0014:HandleAsync|}()
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task HandleMethodWithOnlyCancellationToken_Static_AlertDiagnostic() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
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
			public static partial class {|IHR0019:GetUsersQuery|}
			{
				public record Query;
			
				private static ValueTask<int> {|IHR0014:HandleAsync|}(
					CancellationToken token
				)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task HandleMethodWithZeroParameters_Instance_AlertDiagnostic() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
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
			public sealed partial class GetUsersQuery
			{
				public record Query;
			
				private ValueTask<int> {|IHR0014:HandleAsync|}()
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task HandleMethodWithOnlyCancellationToken_Instance_AlertDiagnostic() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
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
			public sealed partial class GetUsersQuery
			{
				public record Query;
			
				private ValueTask<int> {|IHR0014:HandleAsync|}(
					CancellationToken token
				)
				{
					return ValueTask.FromResult(0);
				}
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);
}
