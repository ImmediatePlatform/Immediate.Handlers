# Immediate.Handlers

[![NuGet](https://img.shields.io/nuget/v/Immediate.Handlers.svg?style=plastic)](https://www.nuget.org/packages/Immediate.Handlers/)
[![GitHub release](https://img.shields.io/github/release/viceroypenguin/Immediate.Handlers.svg)](https://GitHub.com/viceroypenguin/Immediate.Handlers/releases/)
[![GitHub license](https://img.shields.io/github/license/viceroypenguin/Immediate.Handlers.svg)](https://github.com/viceroypenguin/Immediate.Handlers/blob/master/license.txt) 
[![GitHub issues](https://img.shields.io/github/issues/viceroypenguin/Immediate.Handlers.svg)](https://GitHub.com/viceroypenguin/Immediate.Handlers/issues/) 
[![GitHub issues-closed](https://img.shields.io/github/issues-closed/viceroypenguin/Immediate.Handlers.svg)](https://GitHub.com/viceroypenguin/Immediate.Handlers/issues?q=is%3Aissue+is%3Aclosed) 
[![GitHub Actions](https://github.com/viceroypenguin/Immediate.Handlers/actions/workflows/build.yml/badge.svg)](https://github.com/viceroypenguin/Immediate.Handlers/actions)
---

Immediate.Handlers is an implementation of the mediator pattern in .NET using source-generation. All pipeline behaviors
are determined and the call-tree built at compile-time; meaning that all dependencies are enforced via compile-time
safety checks. Behaviors and dependencies are obtained via DI at runtime based on compile-time determined dependencies.

#### Examples
* Minimal Api: [Normal](./samples/Normal)

## Installing Immediate.Handlers

You can install [Immediate.Handlers with NuGet](https://www.nuget.org/packages/Immediate.Handlers):

    Install-Package Immediate.Handlers
    
Or via the .NET Core command line interface:

    dotnet add package Immediate.Handlers

Either commands, from Package Manager Console or .NET Core CLI, will download and install Immediate.Handlers.

## Using Immediate.Handlers
### Creating Handlers

Create a Handler by adding the following code:

```cs
[Handler]
public static class GetUsersQuery
{
    public record Query;

    private static ValueTask<IEnumerable<User>> HandleAsync(
        Query _,
        UsersService usersService,
        CancellationToken token)
    {
        return usersService.GetUsers();
    }
}
```

This will automatically create a new class, `GetUsersQuery.Handler`, which encapsulates the following:
* attaching any behaviors defined for all queries in the assembly
* using a class to receive any DI services, such as `UsersService`

Any consumer can now do the following:
```cs
public class Consumer(GetUsersQuery.Handler handler)
{
	public async Task Consumer(CancellationToken token)
	{
		var response = await handler.HandleAsync(new(), token);
		// do something with response
	}
}
```

### Creating Behaviors

Create a behavior by implementing the `Immediate.Handlers.Shared.Behaviors<,>` class, as so:
```cs
public sealed class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
	: Behavior<TRequest, TResponse>
{
	public override async ValueTask<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken)
	{
		logger.LogInformation("LoggingBehavior.Enter");
		var response = await Next(request, cancellationToken);
		logger.LogInformation("LoggingBehavior.Exit");
		return response;
	}
}
```

This can be registered assembly-wide using:
```cs
[assembly: Behaviors(
	typeof(LoggingBehavior<,>)
)]
```

or on an individual handler using:
```cs
[Handler]
[Behavior(
	typeof(LoggingBehavior<,>)
)]
public static class GetUsersQuery
{
	// ..
}
```

Once added to the pipeline, the behavior will be called as part of the pipeline to handle a request.

Note: adding a `[Behavior]` attribute to a handler will disregard all assembly-wide behaviors for that handler, so any
global behaviors necessary must be independently added to the handler override behaviors list.

#### Behavior Constraints

A constraint can be added to a behavior by using:
```cs
public sealed class LoggingBehavior<TRequest, TResponse>
	: Behavior<TRequest, TResponse>
	where TRequest : IRequestConstraint
	where TResponse : IResponseConstraint
```

When a pipeline is generated, all potential behaviors are evaluated against the request and response types, and if
either type does not match a given constraint, the behavior is not added to the generated pipeline.

### Registering with `IServiceCollection`

Immediate.Handlers supports `Microsoft.Extensions.DependencyInjection.Abstractions` directly. 

#### Registering Handlers

```cs
services.AddHandlers();
```

This registers all classes in the assembly marked with `[Handler]`.

#### Registering Behaviors

```cs
services.AddBehaviors();
```

This registers all behaviors referenced in any `[Behaviors]` attribute.

## Performance Comparisons

All performance benchmarks reported use the following environment:
```
// * Summary *

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
```

#### [Benchmarks.Simple](./Benchmarks/Benchmark.Simple)

This benchmark tests the various mediator implementations with a single request/response handler.

| Method                       | Mean       | Error     | StdDev    | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |-----------:|----------:|----------:|------:|--------:|-----:|-------:|----------:|------------:|
| SendRequest_Baseline         |  0.9303 ns | 0.0120 ns | 0.0113 ns |  1.00 |    0.00 |    1 |      - |         - |          NA |
| SendRequest_ImmediateHandler | 15.2625 ns | 0.0691 ns | 0.0646 ns | 16.41 |    0.19 |    2 |      - |         - |          NA |
| SendRequest_Mediator         | 27.0657 ns | 0.1025 ns | 0.0959 ns | 29.10 |    0.33 |    3 |      - |         - |          NA |
| SendRequest_IMediator        | 31.2996 ns | 0.0943 ns | 0.0882 ns | 33.65 |    0.43 |    4 |      - |         - |          NA |
| SendRequest_MediatR          | 74.5688 ns | 1.1917 ns | 1.0564 ns | 80.12 |    1.77 |    5 | 0.0191 |     240 B |          NA |

#### [Benchmarks.Large](./Benchmarks/Benchmark.Large)

This benchmark tests the various mediator implementations in the face of 999 request/response handlers.

| Method                       | Mean        | Error     | StdDev    | Ratio  | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |------------:|----------:|----------:|-------:|--------:|-----:|-------:|----------:|------------:|
| SendRequest_Baseline         |   0.9190 ns | 0.0272 ns | 0.0254 ns |   1.00 |    0.00 |    1 |      - |         - |          NA |
| SendRequest_ImmediateHandler |  15.4860 ns | 0.0990 ns | 0.0827 ns |  16.87 |    0.49 |    2 |      - |         - |          NA |
| SendRequest_Mediator         |  27.7373 ns | 0.4364 ns | 0.4082 ns |  30.21 |    1.04 |    3 |      - |         - |          NA |
| SendRequest_MediatR          |  79.6346 ns | 0.5683 ns | 0.4746 ns |  86.77 |    2.31 |    4 | 0.0191 |     240 B |          NA |
| SendRequest_IMediator        | 429.8377 ns | 7.4163 ns | 6.9372 ns | 468.07 |   15.50 |    5 |      - |         - |          NA |

#### [Benchmarks.Behaviors](./Benchmarks/Benchmark.Behaviors)

This benchmark tests a more realistic scenario of using 1 behavior and 1 service.

| Method                       | Mean      | Error    | StdDev   | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |----------:|---------:|---------:|------:|--------:|-----:|-------:|----------:|------------:|
| SendRequest_Baseline         |  54.90 ns | 0.177 ns | 0.166 ns |  1.00 |    0.00 |    1 | 0.0032 |      40 B |        1.00 |
| SendRequest_ImmediateHandler |  78.11 ns | 0.286 ns | 0.268 ns |  1.42 |    0.01 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_Mediator         |  96.94 ns | 0.268 ns | 0.224 ns |  1.77 |    0.01 |    3 | 0.0031 |      40 B |        1.00 |
| SendRequest_IMediator        | 106.64 ns | 0.588 ns | 0.550 ns |  1.94 |    0.01 |    4 | 0.0031 |      40 B |        1.00 |
| SendRequest_MediatR          | 198.24 ns | 0.860 ns | 0.718 ns |  3.61 |    0.02 |    5 | 0.0446 |     560 B |       14.00 |
