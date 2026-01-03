using BenchmarkDotNet.Running;
using Immediate.Handlers.Benchmarks;
using RhoMicro.BdnLogging;

BenchmarkRunner.Run<RequestBenchmarks>(
	SpotlightConfig.Instance,
	args
);
