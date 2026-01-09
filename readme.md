# Immediate.Handlers

[![NuGet](https://img.shields.io/nuget/v/Immediate.Handlers.svg?style=plastic)](https://www.nuget.org/packages/Immediate.Handlers/)
[![GitHub release](https://img.shields.io/github/release/ImmediatePlatform/Immediate.Handlers.svg)](https://GitHub.com/ImmediatePlatform/Immediate.Handlers/releases/)
[![GitHub license](https://img.shields.io/github/license/ImmediatePlatform/Immediate.Handlers.svg)](https://github.com/ImmediatePlatform/Immediate.Handlers/blob/master/license.txt) 
[![GitHub issues](https://img.shields.io/github/issues/ImmediatePlatform/Immediate.Handlers.svg)](https://GitHub.com/ImmediatePlatform/Immediate.Handlers/issues/) 
[![GitHub issues-closed](https://img.shields.io/github/issues-closed/ImmediatePlatform/Immediate.Handlers.svg)](https://GitHub.com/ImmediatePlatform/Immediate.Handlers/issues?q=is%3Aissue+is%3Aclosed) 
[![GitHub Actions](https://github.com/ImmediatePlatform/Immediate.Handlers/actions/workflows/build.yml/badge.svg)](https://github.com/ImmediatePlatform/Immediate.Handlers/actions)
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
public sealed partial class GetUsersQuery(
	UsersService usersService
)
{
    public record Query;

    private ValueTask<IEnumerable<User>> HandleAsync(
        Query _,
        CancellationToken token
	)
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

For Command handlers, use a `ValueTask`, and Immediate.Handlers will insert a return type
of `ValueTuple` to your handler automatically. 
```cs
[Handler]
public sealed partial class CreateUserCommand()
    UsersService usersService
)
{
    public record Command(string Email);

    private async ValueTask HandleAsync( 
        Command command,
        CancellationToken token
	)
    {
        await usersService.CreateUser(command.Email);
    }
}
```

In case your project layout does not allow direct for references between consumer and handler, the handler will also be
registered as an `IHandler<TRequest, Response>`.

```cs
public class Consumer(IHandler<Query, IEnumerable<User>> handler)
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

### Using Behaviors

Once added to the pipeline, the behavior will be called as part of the pipeline to handle a request. They can be added
to the pipeline one of three ways: 

* Behaviors can be registered assembly-wide by using an `[assembly: ]` attribute, as shown here:
```cs
[assembly: Behaviors(
	typeof(LoggingBehavior<,>)
)]
```

* Behaviors can be applied on an individual handler using:
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

* Common behavior pipelines can be defined by applying a `[Behaviors]` attribute another attribute, as shown here:
```cs
[Behaviors(
  typeof(ValidationBehavior<,>), typeof(TransactionBehavior<,>)
)]
public sealed class DefaultBehaviorsAttribute : Attribute;

// usage
[Handler]
[DefaultBehaviors]
public sealed class GetUsersQuery
{
	// ..
}
```

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

In your `Program.cs`, add a call to `services.AddXxxHandlers()`, where `Xxx` is the shortened form of the project name.
* For a project named `Web`, it will be `services.AddWebHandlers()`
* For a project named `Application.Web`, it will be `services.AddApplicationWebHandlers()`

This registers all classes in the assembly marked with `[Handler]`.

#### Registering Behaviors

In your `Program.cs`, add a call to `services.AddXxxBehaviors()`, where `Xxx` is the shortened form of the project name.
* For a project named `Web`, it will be `services.AddWebBehaviors()`
* For a project named `Application.Web`, it will be `services.AddApplicationWebBehaviors()`

This registers all behaviors referenced in any `[Behaviors]` attribute.

### Using with Swashbuckle
For Swagger to work the JSON schema generated is required to have unique schemaId's. To achieve this, Swashbuckle uses class names as simple schemaId's.
When using Immediate Handlers classes with a controller action inside, you might end up with Swashbuckle stating an error similar to this:

```
Swashbuckle.AspNetCore.SwaggerGen.SwaggerGeneratorException: Failed to generate schema for type - MyApp.Api.DeleteUser+Command. See inner exception
System.InvalidOperationException: Can't use schemaId "$Command" for type "$MyApp.Api.DeleteUser+Command". The same schemaId is already used for type "$MyApp.Api.CreateUserCommand+Command"
```

This error indicates Swashbuckle is trying to use two classes named `Command` from two (or more) different Handlers in different namespaces.

To fix this, you have to define the following options in your SwaggerGen configuration:

```cs
builder.Services.AddSwaggerGen( options =>
{
    options.CustomSchemaIds(x => x.FullName?.Replace("+", ".", StringComparison.Ordinal));
});
```

## Performance Comparisons

#### Offerings:

This performance comparison covers the following popular mediator/command-dispatch libraries:
* Immediate.Handlers (`SendRequest_ImmediateStaticHandler`, `SendRequest_ImmediateHandler_Abstraction`, `SendRequest_ImmediateSealedHandler`)
* [martinothamar/Mediator v3.0.1](https://github.com/martinothamar/Mediator) (`SendRequest_IMediator`, `SendRequest_Mediator`)
* [MediatR v12.5.0](https://github.com/LuckyPennySoftware/MediatR) (`SendRequest_MediatR`)
* [Foundatio.Mediator](https://github.com/FoundatioFx/Foundatio.Mediator) (`SendRequest_Foundatio`)

#### [Benchmarks.Simple](./benchmarks/Benchmark.Simple)

This benchmark tests the various mediator implementations with a single request/response handler.

| Method                                   | Mean       | Error     | Ratio  | Rank | Allocated |
|----------------------------------------- |-----------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline                     |  0.6450 ns | 0.0208 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | 10.4205 ns | 0.1099 ns |  16.17 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | 10.5258 ns | 0.0508 ns |  16.33 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | 11.3449 ns | 0.0690 ns |  17.60 |    3 |         - |
| SendRequest_Foundatio                    | 15.5163 ns | 0.3198 ns |  24.08 |    4 |         - |
| SendRequest_Mediator_IMediator           | 37.2734 ns | 0.0921 ns |  57.84 |    5 |      64 B |
| SendRequest_Mediator                     | 38.4093 ns | 0.2258 ns |  59.60 |    6 |      64 B |
| SendRequest_MediatR                      | 39.7945 ns | 0.1020 ns |  61.75 |    7 |     200 B |

<details>
<summary>Full Details</summary>

```
// * Summary *

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
12th Gen Intel Core i7-12700H 2.30GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.11 (9.0.11, 9.0.1125.51716), X64 RyuJIT x86-64-v3

```
| Method                                   | Runtime   | Mean       | Error     | Ratio  | Rank | Allocated |
|----------------------------------------- |---------- |-----------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline                     | .NET 8.0  |  0.6765 ns | 0.0241 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 8.0  | 15.2941 ns | 0.1168 ns |  22.63 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 8.0  | 16.2566 ns | 0.1269 ns |  24.06 |    3 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 8.0  | 16.3605 ns | 0.2793 ns |  24.21 |    3 |         - |
| SendRequest_Foundatio                    | .NET 8.0  | 29.8069 ns | 0.2227 ns |  44.11 |    4 |         - |
| SendRequest_Mediator                     | .NET 8.0  | 48.0494 ns | 0.3259 ns |  71.10 |    5 |      64 B |
| SendRequest_Mediator_IMediator           | .NET 8.0  | 54.7005 ns | 0.1420 ns |  80.94 |    6 |      64 B |
| SendRequest_MediatR                      | .NET 8.0  | 72.8629 ns | 0.4342 ns | 107.82 |    7 |     312 B |
|                                          |           |            |           |        |      |           |
| SendRequest_Baseline                     | .NET 9.0  |  0.7307 ns | 0.0213 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  | 10.7849 ns | 0.0289 ns |  14.77 |    2 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  | 10.9026 ns | 0.0571 ns |  14.93 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  | 13.7813 ns | 0.0343 ns |  18.87 |    3 |         - |
| SendRequest_Foundatio                    | .NET 9.0  | 27.9229 ns | 0.1604 ns |  38.24 |    4 |         - |
| SendRequest_Mediator                     | .NET 9.0  | 49.6755 ns | 0.1708 ns |  68.03 |    5 |      64 B |
| SendRequest_MediatR                      | .NET 9.0  | 50.9047 ns | 0.2250 ns |  69.71 |    5 |     264 B |
| SendRequest_Mediator_IMediator           | .NET 9.0  | 51.7191 ns | 0.1580 ns |  70.83 |    5 |      64 B |
|                                          |           |            |           |        |      |           |
| SendRequest_Baseline                     | .NET 10.0 |  0.6450 ns | 0.0208 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 | 10.4205 ns | 0.1099 ns |  16.17 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 | 10.5258 ns | 0.0508 ns |  16.33 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 | 11.3449 ns | 0.0690 ns |  17.60 |    3 |         - |
| SendRequest_Foundatio                    | .NET 10.0 | 15.5163 ns | 0.3198 ns |  24.08 |    4 |         - |
| SendRequest_Mediator_IMediator           | .NET 10.0 | 37.2734 ns | 0.0921 ns |  57.84 |    5 |      64 B |
| SendRequest_Mediator                     | .NET 10.0 | 38.4093 ns | 0.2258 ns |  59.60 |    6 |      64 B |
| SendRequest_MediatR                      | .NET 10.0 | 39.7945 ns | 0.1020 ns |  61.75 |    7 |     200 B |

</details>

#### [Benchmarks.Large](./benchmarks/Benchmark.Large)

This benchmark tests the various mediator implementations in the face of 999 request/response handlers.

| Method                                   | Mean       | Error     | Ratio  | Rank | Allocated |
|----------------------------------------- |-----------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline                     |  0.7325 ns | 0.0297 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | 10.3242 ns | 0.0337 ns |  14.11 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | 10.4817 ns | 0.0691 ns |  14.33 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | 11.1883 ns | 0.0590 ns |  15.29 |    3 |         - |
| SendRequest_Foundatio                    | 18.1992 ns | 0.1998 ns |  24.88 |    4 |         - |
| SendRequest_MediatR                      | 39.1257 ns | 0.2281 ns |  53.49 |    5 |     200 B |
| SendRequest_Mediator                     | 40.7936 ns | 0.2116 ns |  55.77 |    6 |      64 B |
| SendRequest_Mediator_IMediator           | 51.2714 ns | 0.6097 ns |  70.09 |    7 |      64 B |

<details>
<summary>Full Details</summary>

```
// * Summary *

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
12th Gen Intel Core i7-12700H 2.30GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.11 (9.0.11, 9.0.1125.51716), X64 RyuJIT x86-64-v3

```
| Method                                   | Runtime   | Mean       | Error     | Ratio  | Rank | Allocated |
|----------------------------------------- |---------- |-----------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline                     | .NET 8.0  |  0.8697 ns | 0.0131 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 8.0  | 15.4745 ns | 0.0913 ns |  17.80 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 8.0  | 15.9583 ns | 0.0374 ns |  18.35 |    3 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 8.0  | 16.4651 ns | 0.1817 ns |  18.93 |    3 |         - |
| SendRequest_Foundatio                    | .NET 8.0  | 29.1745 ns | 0.2186 ns |  33.55 |    4 |         - |
| SendRequest_Mediator                     | .NET 8.0  | 54.2472 ns | 0.2428 ns |  62.38 |    5 |      64 B |
| SendRequest_MediatR                      | .NET 8.0  | 73.7124 ns | 0.6082 ns |  84.77 |    6 |     312 B |
| SendRequest_Mediator_IMediator           | .NET 8.0  | 76.0302 ns | 0.2241 ns |  87.44 |    6 |      64 B |
|                                          |           |            |           |        |      |           |
| SendRequest_Baseline                     | .NET 9.0  |  0.6466 ns | 0.0288 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  | 10.9687 ns | 0.1400 ns |  16.99 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  | 11.7406 ns | 0.0752 ns |  18.19 |    3 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  | 14.1281 ns | 0.1087 ns |  21.88 |    4 |         - |
| SendRequest_Foundatio                    | .NET 9.0  | 27.6113 ns | 0.3321 ns |  42.77 |    5 |         - |
| SendRequest_Mediator                     | .NET 9.0  | 52.1462 ns | 0.1326 ns |  80.77 |    6 |      64 B |
| SendRequest_MediatR                      | .NET 9.0  | 56.2832 ns | 0.1777 ns |  87.18 |    7 |     264 B |
| SendRequest_Mediator_IMediator           | .NET 9.0  | 68.6525 ns | 0.3492 ns | 106.34 |    8 |      64 B |
|                                          |           |            |           |        |      |           |
| SendRequest_Baseline                     | .NET 10.0 |  0.7325 ns | 0.0297 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 | 10.3242 ns | 0.0337 ns |  14.11 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 | 10.4817 ns | 0.0691 ns |  14.33 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 | 11.1883 ns | 0.0590 ns |  15.29 |    3 |         - |
| SendRequest_Foundatio                    | .NET 10.0 | 18.1992 ns | 0.1998 ns |  24.88 |    4 |         - |
| SendRequest_MediatR                      | .NET 10.0 | 39.1257 ns | 0.2281 ns |  53.49 |    5 |     200 B |
| SendRequest_Mediator                     | .NET 10.0 | 40.7936 ns | 0.2116 ns |  55.77 |    6 |      64 B |
| SendRequest_Mediator_IMediator           | .NET 10.0 | 51.2714 ns | 0.6097 ns |  70.09 |    7 |      64 B |

</details>

#### [Benchmarks.Behaviors](./benchmarks/Benchmark.Behaviors)

This benchmark tests a more realistic scenario of using 1 behavior and 1 service.

| Method                                   | Mean      | Error    | Ratio | Rank | Allocated |
|----------------------------------------- |----------:|---------:|------:|-----:|----------:|
| SendRequest_Baseline                     |  44.17 ns | 0.103 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateSealedHandler       |  56.48 ns | 0.334 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateHandler_Abstraction |  56.68 ns | 0.344 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateStaticHandler       |  57.54 ns | 0.525 ns |  1.30 |    2 |      40 B |
| SendRequest_Mediator_IMediator           | 120.81 ns | 0.616 ns |  2.74 |    3 |     200 B |
| SendRequest_Mediator                     | 124.33 ns | 0.810 ns |  2.81 |    3 |     200 B |
| SendRequest_Foundatio                    | 124.71 ns | 0.475 ns |  2.82 |    3 |     264 B |
| SendRequest_MediatR                      | 166.71 ns | 2.067 ns |  3.77 |    4 |     496 B |

<details>
<summary>Full Details</summary>

```
// * Summary *

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
12th Gen Intel Core i7-12700H 2.30GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.11 (9.0.11, 9.0.1125.51716), X64 RyuJIT x86-64-v3

```
| Method                                   | Runtime   | Mean      | Error    | Ratio | Rank | Allocated |
|----------------------------------------- |---------- |----------:|---------:|------:|-----:|----------:|
| SendRequest_Baseline                     | .NET 8.0  |  52.49 ns | 0.187 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateStaticHandler       | .NET 8.0  |  73.94 ns | 0.326 ns |  1.41 |    2 |      40 B |
| SendRequest_ImmediateSealedHandler       | .NET 8.0  |  74.42 ns | 0.244 ns |  1.42 |    2 |      40 B |
| SendRequest_ImmediateHandler_Abstraction | .NET 8.0  |  75.52 ns | 0.990 ns |  1.44 |    2 |      40 B |
| SendRequest_Mediator                     | .NET 8.0  | 141.04 ns | 0.729 ns |  2.69 |    3 |     200 B |
| SendRequest_Foundatio                    | .NET 8.0  | 150.44 ns | 0.680 ns |  2.87 |    4 |     264 B |
| SendRequest_Mediator_IMediator           | .NET 8.0  | 150.59 ns | 0.667 ns |  2.87 |    4 |     200 B |
| SendRequest_MediatR                      | .NET 8.0  | 194.16 ns | 0.975 ns |  3.70 |    5 |     560 B |
|                                          |           |           |          |       |      |           |
| SendRequest_Baseline                     | .NET 9.0  |  47.27 ns | 0.176 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  |  60.01 ns | 0.356 ns |  1.27 |    2 |      40 B |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  |  61.47 ns | 0.173 ns |  1.30 |    2 |      40 B |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  |  62.56 ns | 0.257 ns |  1.32 |    2 |      40 B |
| SendRequest_Mediator                     | .NET 9.0  | 132.40 ns | 0.640 ns |  2.80 |    3 |     200 B |
| SendRequest_Mediator_IMediator           | .NET 9.0  | 138.23 ns | 0.921 ns |  2.92 |    4 |     200 B |
| SendRequest_Foundatio                    | .NET 9.0  | 143.37 ns | 1.437 ns |  3.03 |    5 |     264 B |
| SendRequest_MediatR                      | .NET 9.0  | 187.89 ns | 0.778 ns |  3.97 |    6 |     560 B |
|                                          |           |           |          |       |      |           |
| SendRequest_Baseline                     | .NET 10.0 |  44.17 ns | 0.103 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 |  56.48 ns | 0.334 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 |  56.68 ns | 0.344 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 |  57.54 ns | 0.525 ns |  1.30 |    2 |      40 B |
| SendRequest_Mediator_IMediator           | .NET 10.0 | 120.81 ns | 0.616 ns |  2.74 |    3 |     200 B |
| SendRequest_Mediator                     | .NET 10.0 | 124.33 ns | 0.810 ns |  2.81 |    3 |     200 B |
| SendRequest_Foundatio                    | .NET 10.0 | 124.71 ns | 0.475 ns |  2.82 |    3 |     264 B |
| SendRequest_MediatR                      | .NET 10.0 | 166.71 ns | 2.067 ns |  3.77 |    4 |     496 B |

</details>
