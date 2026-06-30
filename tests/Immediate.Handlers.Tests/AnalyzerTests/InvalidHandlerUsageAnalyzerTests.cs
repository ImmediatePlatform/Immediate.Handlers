using Immediate.Handlers.Analyzers;

namespace Immediate.Handlers.Tests.AnalyzerTests;

public sealed class InvalidHandlerUsageAnalyzerTests
{
	[Fact]
	public async Task AnalyzerTriggersForUseAsGenericBaseType() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public interface IInterface<T>;

			[Handler]
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class {|IHR0022:Test2|} : IInterface<Test>;
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForNonUseAsGenericBaseType() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public interface IInterface<T>;

			[Handler]
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2 : IInterface<Test.Handler>;
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerTriggersForUseAsBaseType() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public interface IInterface<T>;

			[Handler]
			public partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class {|IHR0022:Test2|} : Test;
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForNonUseAsBaseType() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public interface IInterface<T>;

			[Handler]
			public sealed partial class Test
			{
				public record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public record Test2 : Test.Query;
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerTriggersForUseAsField() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private {|IHR0022:Test|} _test;
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForNonUseAsField() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private Test.Handler _test;
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerTriggersForUseAsProperty() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private {|IHR0022:Test|} Test { get; init; }
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForNonUseAsProperty() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private Test.Handler Test { get; init; }
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerTriggersForUseAsParameter() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private void Method({|IHR0022:Test|} test) { }
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForNonUseAsParameter() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private void Method(Test.Handler test) { }
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerTriggersForUseAsMethodReturn() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private {|IHR0022:Test|} Method(int test) => new();
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForNonUseAsMethodReturn() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
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
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private Test.Handler Method(int test) => default!;
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerTriggersForUseAsT() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;

			public interface IInterface<T>;

			[Handler]
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private void Method({|IHR0022:IInterface<Test>|} test) { }
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);

	[Fact]
	public async Task AnalyzerDoesNotTriggerForUseAsILoggerT() =>
		await AnalyzerTestHelpers.CreateAnalyzerTest<InvalidHandlerUsageAnalyzer>(
			"""
			using System;
			using System.Collections.Generic;
			using System.IO;
			using System.Linq;
			using System.Net.Http;
			using System.Threading;
			using System.Threading.Tasks;
			using Immediate.Handlers.Shared;
			using Microsoft.Extensions.Logging;

			[Handler]
			public sealed partial class Test
			{
				public sealed record Query;
				public sealed record Response;

				private async ValueTask<Response> HandleAsync(Query query, CancellationToken token) =>
					new();
			}

			public class Test2
			{
				private void Method(ILogger<Test> test) { }
			}
			"""
		).RunAsync(TestContext.Current.CancellationToken);
}
