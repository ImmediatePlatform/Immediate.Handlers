using System.Text;
using Immediate.Handlers.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Testing;

namespace Immediate.Handlers.Tests.AnalyzerTests.HandlerClassAnalyzerTests;

public partial class Tests
{
	private const string StaticNoDependencies =
		// lang=c#-test
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
		public static partial class {|#0:GetUsersQuery|}
		{
			public record Query;
		
			private static ValueTask<int> HandleAsync(
				Query _,
				CancellationToken token)
			{
				return ValueTask.FromResult(0);
			}
		}
		""";

	private const string StaticDependencies =
		// lang=c#-test
		"""
		using System;
		using System.Collections.Generic;
		using System.IO;
		using System.Linq;
		using System.Net.Http;
		using System.Threading;
		using System.Threading.Tasks;
		using Immediate.Handlers.Shared;

		public class UserService;
		
		[Handler]
		public static partial class {|#0:GetUsersQuery|}
		{
			public record Query;
		
			private static ValueTask<int> HandleAsync(
				Query _,
				UserService userService,
				CancellationToken token)
			{
				return ValueTask.FromResult(0);
			}
		}
		""";

	private const string SealedNoDependencies =
		// lang=c#-test
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
		public sealed partial class {|#0:GetUsersQuery|}
		{
			public record Query;
		
			private ValueTask<int> HandleAsync(
				Query _,
				CancellationToken token)
			{
				return ValueTask.FromResult(0);
			}
		}
		""";

	private const string SealedDependencies =
		// lang=c#-test
		"""
		using System;
		using System.Collections.Generic;
		using System.IO;
		using System.Linq;
		using System.Net.Http;
		using System.Threading;
		using System.Threading.Tasks;
		using Immediate.Handlers.Shared;

		public class UserService;
		
		[Handler]
		public sealed partial class {|#0:GetUsersQuery|}(UserService userService)
		{
			public record Query;
		
			private ValueTask<int> HandleAsync(
				Query _,
				CancellationToken token)
			{
				return ValueTask.FromResult(0);
			}
		}
		""";

	private static readonly CompositeFormat EditorConfig =
		CompositeFormat.Parse(
			"""
			root = true

			[*.cs]
			dotnet_diagnostic.IHR0019.enable_when_handler_has_no_dependencies = {0}
			"""
		);

	[Theory]
	[InlineData(StaticNoDependencies, false, false)]
	[InlineData(StaticNoDependencies, null, false)]
	[InlineData(StaticNoDependencies, true, true)]
	[InlineData(StaticDependencies, false, true)]
	[InlineData(StaticDependencies, null, true)]
	[InlineData(StaticDependencies, true, true)]
	[InlineData(SealedNoDependencies, false, false)]
	[InlineData(SealedNoDependencies, null, false)]
	[InlineData(SealedNoDependencies, true, false)]
	[InlineData(SealedDependencies, false, false)]
	[InlineData(SealedDependencies, null, false)]
	[InlineData(SealedDependencies, true, false)]
	public async Task StaticHandlerCanBeSealed(string source, bool? enableWithNoDependencies, bool triggerDiagnostic)
	{
		var test = AnalyzerTestHelpers.CreateAnalyzerTest<HandlerClassAnalyzer>(
			source,
			DriverReferenceAssemblies.Normal
		);

		if (triggerDiagnostic)
		{
			test.ExpectedDiagnostics.Add(
				new DiagnosticResult("IHR0019", DiagnosticSeverity.Info)
					.WithLocation(0)
			);
		}

		if (enableWithNoDependencies is { } b)
		{
			test.TestState.AnalyzerConfigFiles.Add(("/.editorconfig", string.Format(provider: null, EditorConfig, b)));
		}

		await test.RunAsync(TestContext.Current.CancellationToken);
	}
}
