using Immediate.Handlers.Analyzers;
using Immediate.Handlers.Tests.Helpers;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public sealed class BehaviorClassAnalyzerTests
{
	[Fact]
	public async Task NoConstraints_DoesNotAlert() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed class TestBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task ValidInterfaceConstraint_DoesNotAlert() =>
	await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
		"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public interface IDummy;
			
			public sealed class TestBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TResponse : IDummy
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
		DriverReferenceAssemblies.Normal
	).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task ValidClassConstraint_DoesNotAlert() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public class Dummy;

			public sealed class TestBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : Dummy
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task ValidRecordConstraint_DoesNotAlert() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public record Dummy;
			
			public sealed class TestBehavior<TRequest, TResponse> : Behavior<TRequest, TResponse>
				where TResponse : Dummy
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task InvalidClassConstraint_Alerts() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed class TestBehavior<{|IHR0021:TRequest|}, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : class
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task InvalidNotNullConstraint_Alerts() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed class TestBehavior<{|IHR0021:TRequest|}, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : notnull
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task InvalidStructConstraint_Alerts() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed class TestBehavior<{|IHR0021:TRequest|}, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : struct
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task InvalidUnmanagedConstraint_Alerts() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<BehaviorsClassAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public sealed class TestBehavior<{|IHR0021:TRequest|}, TResponse> : Behavior<TRequest, TResponse>
				where TRequest : unmanaged
			{
				public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken) =>
					default;
			}
			""",
			DriverReferenceAssemblies.Normal
		).RunAsync(TestContext.Current.CancellationToken);
}
