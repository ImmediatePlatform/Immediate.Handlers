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

| Method                                   | Mean        | Error     | Ratio  | Rank | Allocated |
|----------------------------------------- |------------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline                     |   0.6851 ns | 0.0225 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       |  10.8676 ns | 0.0828 ns |  15.88 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction |  11.6256 ns | 0.0559 ns |  16.98 |    3 |         - |
| SendRequest_ImmediateSealedHandler       |  11.6731 ns | 0.1154 ns |  17.05 |    3 |         - |
| SendRequest_IMediator                    |  37.3484 ns | 0.1002 ns |  54.56 |    4 |      64 B |
| SendRequest_Mediator                     |  38.6042 ns | 0.1169 ns |  56.39 |    5 |      64 B |
| SendRequest_MediatR                      |  39.8987 ns | 0.1002 ns |  58.28 |    6 |     200 B |
| SendRequest_Foundatio                    |  86.5151 ns | 0.4276 ns | 126.38 |    7 |     352 B |

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
| Method                                   | Job       | Runtime   | Mean        | Error     | StdDev    | Ratio  | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|----------------------------------------- |---------- |---------- |------------:|----------:|----------:|-------:|--------:|-----:|-------:|----------:|------------:|
| SendRequest_Baseline                     | .NET 10.0 | .NET 10.0 |   0.6851 ns | 0.0225 ns | 0.0199 ns |   1.00 |    0.04 |    1 |      - |         - |          NA |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 | .NET 10.0 |  10.8676 ns | 0.0828 ns | 0.0775 ns |  15.88 |    0.46 |    2 |      - |         - |          NA |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 | .NET 10.0 |  11.6256 ns | 0.0559 ns | 0.0495 ns |  16.98 |    0.48 |    3 |      - |         - |          NA |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 | .NET 10.0 |  11.6731 ns | 0.1154 ns | 0.1023 ns |  17.05 |    0.50 |    3 |      - |         - |          NA |
| SendRequest_IMediator                    | .NET 10.0 | .NET 10.0 |  37.3484 ns | 0.1002 ns | 0.0888 ns |  54.56 |    1.55 |    4 | 0.0051 |      64 B |          NA |
| SendRequest_Mediator                     | .NET 10.0 | .NET 10.0 |  38.6042 ns | 0.1169 ns | 0.1036 ns |  56.39 |    1.60 |    5 | 0.0051 |      64 B |          NA |
| SendRequest_MediatR                      | .NET 10.0 | .NET 10.0 |  39.8987 ns | 0.1002 ns | 0.0888 ns |  58.28 |    1.65 |    6 | 0.0159 |     200 B |          NA |
| SendRequest_Foundatio                    | .NET 10.0 | .NET 10.0 |  86.5151 ns | 0.4276 ns | 0.3791 ns | 126.38 |    3.61 |    7 | 0.0280 |     352 B |          NA |
|                                          |           |           |             |           |           |        |         |      |        |           |             |
| SendRequest_Baseline                     | .NET 8.0  | .NET 8.0  |   0.6502 ns | 0.0426 ns | 0.0377 ns |   1.00 |    0.08 |    1 |      - |         - |          NA |
| SendRequest_ImmediateHandler_Abstraction | .NET 8.0  | .NET 8.0  |  14.3593 ns | 0.0907 ns | 0.0848 ns |  22.16 |    1.30 |    2 |      - |         - |          NA |
| SendRequest_ImmediateSealedHandler       | .NET 8.0  | .NET 8.0  |  14.8397 ns | 0.0965 ns | 0.0903 ns |  22.90 |    1.35 |    3 |      - |         - |          NA |
| SendRequest_ImmediateStaticHandler       | .NET 8.0  | .NET 8.0  |  15.5450 ns | 0.0900 ns | 0.0798 ns |  23.99 |    1.41 |    4 |      - |         - |          NA |
| SendRequest_Mediator                     | .NET 8.0  | .NET 8.0  |  48.1535 ns | 0.4128 ns | 0.3659 ns |  74.30 |    4.38 |    5 | 0.0051 |      64 B |          NA |
| SendRequest_IMediator                    | .NET 8.0  | .NET 8.0  |  55.4503 ns | 0.2320 ns | 0.2170 ns |  85.56 |    5.01 |    6 | 0.0051 |      64 B |          NA |
| SendRequest_MediatR                      | .NET 8.0  | .NET 8.0  |  71.3230 ns | 0.6574 ns | 0.6149 ns | 110.06 |    6.50 |    7 | 0.0248 |     312 B |          NA |
| SendRequest_Foundatio                    | .NET 8.0  | .NET 8.0  | 104.8854 ns | 0.4166 ns | 0.3897 ns | 161.84 |    9.48 |    8 | 0.0280 |     352 B |          NA |
|                                          |           |           |             |           |           |        |         |      |        |           |             |
| SendRequest_Baseline                     | .NET 9.0  | .NET 9.0  |   0.6732 ns | 0.0256 ns | 0.0239 ns |   1.00 |    0.05 |    1 |      - |         - |          NA |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  | .NET 9.0  |  11.4933 ns | 0.0323 ns | 0.0270 ns |  17.09 |    0.61 |    2 |      - |         - |          NA |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  | .NET 9.0  |  11.5968 ns | 0.0403 ns | 0.0377 ns |  17.25 |    0.62 |    2 |      - |         - |          NA |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  | .NET 9.0  |  14.3908 ns | 0.0522 ns | 0.0488 ns |  21.40 |    0.77 |    3 |      - |         - |          NA |
| SendRequest_Mediator                     | .NET 9.0  | .NET 9.0  |  47.1833 ns | 0.2891 ns | 0.2705 ns |  70.17 |    2.54 |    4 | 0.0051 |      64 B |          NA |
| SendRequest_MediatR                      | .NET 9.0  | .NET 9.0  |  50.8848 ns | 0.7355 ns | 0.6141 ns |  75.68 |    2.84 |    5 | 0.0210 |     264 B |          NA |
| SendRequest_IMediator                    | .NET 9.0  | .NET 9.0  |  51.0589 ns | 0.1456 ns | 0.1291 ns |  75.94 |    2.72 |    5 | 0.0051 |      64 B |          NA |
| SendRequest_Foundatio                    | .NET 9.0  | .NET 9.0  |  94.4583 ns | 0.4820 ns | 0.4509 ns | 140.48 |    5.06 |    6 | 0.0280 |     352 B |          NA |

</details>

#### [Benchmarks.Large](./benchmarks/Benchmark.Large)

This benchmark tests the various mediator implementations in the face of 999 request/response handlers.

| Method                                   | Mean        | Error     | Ratio  | Rank | Allocated |
|----------------------------------------- |------------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline                     |   0.7078 ns | 0.0308 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       |   9.9652 ns | 0.1403 ns |  14.10 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction |  10.2138 ns | 0.0522 ns |  14.45 |    2 |         - |
| SendRequest_ImmediateSealedHandler       |  11.1913 ns | 0.0541 ns |  15.84 |    3 |         - |
| SendRequest_MediatR                      |  46.1988 ns | 0.4149 ns |  65.38 |    4 |     200 B |
| SendRequest_IMediator                    |  48.4692 ns | 0.2277 ns |  68.59 |    5 |      64 B |
| SendRequest_Mediator                     |  53.6276 ns | 0.1591 ns |  75.89 |    6 |      64 B |
| SendRequest_Foundatio                    |  82.4081 ns | 0.4686 ns | 116.62 |    7 |     352 B |

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
| Method                                   | Job       | Runtime   | Mean        | Error     | StdDev    | Ratio  | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|----------------------------------------- |---------- |---------- |------------:|----------:|----------:|-------:|--------:|-----:|-------:|----------:|------------:|
| SendRequest_Baseline                     | .NET 10.0 | .NET 10.0 |   0.7078 ns | 0.0308 ns | 0.0288 ns |   1.00 |    0.06 |    1 |      - |         - |          NA |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 | .NET 10.0 |   9.9652 ns | 0.1403 ns | 0.1313 ns |  14.10 |    0.59 |    2 |      - |         - |          NA |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 | .NET 10.0 |  10.2138 ns | 0.0522 ns | 0.0488 ns |  14.45 |    0.58 |    2 |      - |         - |          NA |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 | .NET 10.0 |  11.1913 ns | 0.0541 ns | 0.0506 ns |  15.84 |    0.63 |    3 |      - |         - |          NA |
| SendRequest_MediatR                      | .NET 10.0 | .NET 10.0 |  46.1988 ns | 0.4149 ns | 0.3881 ns |  65.38 |    2.64 |    4 | 0.0159 |     200 B |          NA |
| SendRequest_IMediator                    | .NET 10.0 | .NET 10.0 |  48.4692 ns | 0.2277 ns | 0.2130 ns |  68.59 |    2.73 |    5 | 0.0051 |      64 B |          NA |
| SendRequest_Mediator                     | .NET 10.0 | .NET 10.0 |  53.6276 ns | 0.1591 ns | 0.1328 ns |  75.89 |    3.01 |    6 | 0.0051 |      64 B |          NA |
| SendRequest_Foundatio                    | .NET 10.0 | .NET 10.0 |  82.4081 ns | 0.4686 ns | 0.3913 ns | 116.62 |    4.65 |    7 | 0.0280 |     352 B |          NA |
|                                          |           |           |             |           |           |        |         |      |        |           |             |
| SendRequest_Baseline                     | .NET 8.0  | .NET 8.0  |   0.6788 ns | 0.0189 ns | 0.0167 ns |   1.00 |    0.03 |    1 |      - |         - |          NA |
| SendRequest_ImmediateStaticHandler       | .NET 8.0  | .NET 8.0  |  14.1657 ns | 0.2175 ns | 0.2035 ns |  20.88 |    0.59 |    2 |      - |         - |          NA |
| SendRequest_ImmediateHandler_Abstraction | .NET 8.0  | .NET 8.0  |  14.9028 ns | 0.1023 ns | 0.0906 ns |  21.97 |    0.56 |    3 |      - |         - |          NA |
| SendRequest_ImmediateSealedHandler       | .NET 8.0  | .NET 8.0  |  14.9546 ns | 0.0720 ns | 0.0638 ns |  22.04 |    0.55 |    3 |      - |         - |          NA |
| SendRequest_Mediator                     | .NET 8.0  | .NET 8.0  |  52.4831 ns | 0.1520 ns | 0.1422 ns |  77.36 |    1.92 |    4 | 0.0051 |      64 B |          NA |
| SendRequest_IMediator                    | .NET 8.0  | .NET 8.0  |  64.1979 ns | 0.3041 ns | 0.2695 ns |  94.63 |    2.37 |    5 | 0.0050 |      64 B |          NA |
| SendRequest_MediatR                      | .NET 8.0  | .NET 8.0  |  82.0569 ns | 0.3886 ns | 0.3635 ns | 120.95 |    3.04 |    6 | 0.0248 |     312 B |          NA |
| SendRequest_Foundatio                    | .NET 8.0  | .NET 8.0  | 103.0772 ns | 0.6224 ns | 0.5822 ns | 151.94 |    3.85 |    7 | 0.0280 |     352 B |          NA |
|                                          |           |           |             |           |           |        |         |      |        |           |             |
| SendRequest_Baseline                     | .NET 9.0  | .NET 9.0  |   0.6120 ns | 0.0237 ns | 0.0198 ns |   1.00 |    0.04 |    1 |      - |         - |          NA |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  | .NET 9.0  |  11.4128 ns | 0.0259 ns | 0.0242 ns |  18.67 |    0.59 |    2 |      - |         - |          NA |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  | .NET 9.0  |  12.1069 ns | 0.0319 ns | 0.0282 ns |  19.80 |    0.63 |    3 |      - |         - |          NA |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  | .NET 9.0  |  14.8606 ns | 0.0694 ns | 0.0615 ns |  24.31 |    0.77 |    4 |      - |         - |          NA |
| SendRequest_Mediator                     | .NET 9.0  | .NET 9.0  |  50.4445 ns | 0.1966 ns | 0.1839 ns |  82.51 |    2.62 |    5 | 0.0051 |      64 B |          NA |
| SendRequest_MediatR                      | .NET 9.0  | .NET 9.0  |  56.9114 ns | 0.2937 ns | 0.2603 ns |  93.09 |    2.96 |    6 | 0.0210 |     264 B |          NA |
| SendRequest_IMediator                    | .NET 9.0  | .NET 9.0  |  58.6013 ns | 0.5051 ns | 0.4724 ns |  95.85 |    3.11 |    6 | 0.0050 |      64 B |          NA |
| SendRequest_Foundatio                    | .NET 9.0  | .NET 9.0  |  94.7206 ns | 0.3739 ns | 0.3497 ns | 154.93 |    4.91 |    7 | 0.0280 |     352 B |          NA |

</details>

#### [Benchmarks.Behaviors](./benchmarks/Benchmark.Behaviors)

This benchmark tests a more realistic scenario of using 1 behavior and 1 service.

| Method                                   | Mean      | Error    | Ratio | Rank | Allocated |
|----------------------------------------- |----------:|---------:|------:|-----:|----------:|
| SendRequest_Baseline                     |  44.02 ns | 0.153 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateSealedHandler       |  56.40 ns | 0.100 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateHandler_Abstraction |  56.55 ns | 0.386 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateStaticHandler       |  57.51 ns | 0.972 ns |  1.31 |    2 |      40 B |
| SendRequest_IMediator                    | 117.29 ns | 0.315 ns |  2.66 |    3 |     200 B |
| SendRequest_Mediator                     | 124.45 ns | 0.458 ns |  2.83 |    4 |     200 B |
| SendRequest_Foundatio                    | 134.99 ns | 0.799 ns |  3.07 |    5 |     416 B |
| SendRequest_MediatR                      | 166.89 ns | 1.092 ns |  3.79 |    6 |     496 B |

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
| Method                                   | Job       | Runtime   | Mean      | Error    | StdDev   | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|----------------------------------------- |---------- |---------- |----------:|---------:|---------:|------:|--------:|-----:|-------:|----------:|------------:|
| SendRequest_Baseline                     | .NET 10.0 | .NET 10.0 |  44.02 ns | 0.153 ns | 0.127 ns |  1.00 |    0.00 |    1 | 0.0032 |      40 B |        1.00 |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 | .NET 10.0 |  56.40 ns | 0.100 ns | 0.088 ns |  1.28 |    0.00 |    2 | 0.0032 |      40 B |        1.00 |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 | .NET 10.0 |  56.55 ns | 0.386 ns | 0.361 ns |  1.28 |    0.01 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 | .NET 10.0 |  57.51 ns | 0.972 ns | 0.862 ns |  1.31 |    0.02 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_IMediator                    | .NET 10.0 | .NET 10.0 | 117.29 ns | 0.315 ns | 0.280 ns |  2.66 |    0.01 |    3 | 0.0157 |     200 B |        5.00 |
| SendRequest_Mediator                     | .NET 10.0 | .NET 10.0 | 124.45 ns | 0.458 ns | 0.383 ns |  2.83 |    0.01 |    4 | 0.0157 |     200 B |        5.00 |
| SendRequest_Foundatio                    | .NET 10.0 | .NET 10.0 | 134.99 ns | 0.799 ns | 0.748 ns |  3.07 |    0.02 |    5 | 0.0331 |     416 B |       10.40 |
| SendRequest_MediatR                      | .NET 10.0 | .NET 10.0 | 166.89 ns | 1.092 ns | 0.968 ns |  3.79 |    0.02 |    6 | 0.0393 |     496 B |       12.40 |
|                                          |           |           |           |          |          |       |         |      |        |           |             |
| SendRequest_Baseline                     | .NET 8.0  | .NET 8.0  |  53.47 ns | 0.285 ns | 0.266 ns |  1.00 |    0.01 |    1 | 0.0032 |      40 B |        1.00 |
| SendRequest_ImmediateStaticHandler       | .NET 8.0  | .NET 8.0  |  73.74 ns | 0.214 ns | 0.200 ns |  1.38 |    0.01 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_ImmediateSealedHandler       | .NET 8.0  | .NET 8.0  |  74.02 ns | 0.399 ns | 0.373 ns |  1.38 |    0.01 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_ImmediateHandler_Abstraction | .NET 8.0  | .NET 8.0  |  75.86 ns | 0.255 ns | 0.239 ns |  1.42 |    0.01 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_Mediator                     | .NET 8.0  | .NET 8.0  | 141.30 ns | 0.561 ns | 0.525 ns |  2.64 |    0.02 |    3 | 0.0157 |     200 B |        5.00 |
| SendRequest_IMediator                    | .NET 8.0  | .NET 8.0  | 143.51 ns | 0.764 ns | 0.677 ns |  2.68 |    0.02 |    3 | 0.0157 |     200 B |        5.00 |
| SendRequest_Foundatio                    | .NET 8.0  | .NET 8.0  | 152.76 ns | 1.721 ns | 1.343 ns |  2.86 |    0.03 |    4 | 0.0331 |     416 B |       10.40 |
| SendRequest_MediatR                      | .NET 8.0  | .NET 8.0  | 199.56 ns | 0.828 ns | 0.774 ns |  3.73 |    0.02 |    5 | 0.0446 |     560 B |       14.00 |
|                                          |           |           |           |          |          |       |         |      |        |           |             |
| SendRequest_Baseline                     | .NET 9.0  | .NET 9.0  |  48.12 ns | 0.457 ns | 0.382 ns |  1.00 |    0.01 |    1 | 0.0032 |      40 B |        1.00 |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  | .NET 9.0  |  59.84 ns | 0.318 ns | 0.297 ns |  1.24 |    0.01 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  | .NET 9.0  |  60.53 ns | 0.204 ns | 0.171 ns |  1.26 |    0.01 |    2 | 0.0031 |      40 B |        1.00 |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  | .NET 9.0  |  62.21 ns | 0.186 ns | 0.156 ns |  1.29 |    0.01 |    3 | 0.0031 |      40 B |        1.00 |
| SendRequest_Mediator                     | .NET 9.0  | .NET 9.0  | 137.21 ns | 0.859 ns | 0.761 ns |  2.85 |    0.03 |    4 | 0.0157 |     200 B |        5.00 |
| SendRequest_IMediator                    | .NET 9.0  | .NET 9.0  | 141.80 ns | 0.714 ns | 0.668 ns |  2.95 |    0.03 |    5 | 0.0157 |     200 B |        5.00 |
| SendRequest_Foundatio                    | .NET 9.0  | .NET 9.0  | 147.28 ns | 0.717 ns | 0.636 ns |  3.06 |    0.03 |    6 | 0.0331 |     416 B |       10.40 |
| SendRequest_MediatR                      | .NET 9.0  | .NET 9.0  | 188.56 ns | 1.369 ns | 1.213 ns |  3.92 |    0.04 |    7 | 0.0446 |     560 B |       14.00 |

</details>
