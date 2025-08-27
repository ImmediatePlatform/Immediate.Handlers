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

All performance benchmarks reported use the following environment:
```
// * Summary *

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
12th Gen Intel Core i7-12700H 2.30GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.100-preview.6.25358.103
  [Host]    : .NET 9.0.8 (9.0.825.36511), X64 RyuJIT AVX2
  .NET 10.0 : .NET 10.0.0 (10.0.25.35903), X64 RyuJIT AVX2
  .NET 9.0  : .NET 9.0.8 (9.0.825.36511), X64 RyuJIT AVX2
```

#### [Benchmarks.Simple](./benchmarks/Benchmark.Simple)

This benchmark tests the various mediator implementations with a single request/response handler.

| Method                                   | Runtime   | Mean       | Error     | Ratio | Rank | Allocated |
|----------------------------------------- |---------- |-----------:|----------:|------:|-----:|----------:|
| SendRequest_Baseline                     | .NET 10.0 |  0.6939 ns | 0.0156 ns |  1.00 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 | 10.7934 ns | 0.1006 ns | 15.56 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 | 11.1127 ns | 0.2450 ns | 16.02 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 | 11.7686 ns | 0.0473 ns | 16.97 |    2 |         - |
| SendRequest_Mediator                     | .NET 10.0 | 22.7844 ns | 0.0959 ns | 32.85 |    3 |         - |
| SendRequest_IMediator                    | .NET 10.0 | 25.8943 ns | 0.0659 ns | 37.33 |    4 |         - |
| SendRequest_MediatR                      | .NET 10.0 | 42.2888 ns | 0.8504 ns | 60.97 |    5 |     200 B |
|                                          |           |            |           |       |      |           |
| SendRequest_Baseline                     | .NET 9.0  |  0.7045 ns | 0.0546 ns |  1.01 |    1 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  | 11.1561 ns | 0.0695 ns | 15.94 |    2 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  | 11.1793 ns | 0.0624 ns | 15.97 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  | 14.2575 ns | 0.0685 ns | 20.37 |    3 |         - |
| SendRequest_Mediator                     | .NET 9.0  | 22.5723 ns | 0.1380 ns | 32.25 |    4 |         - |
| SendRequest_IMediator                    | .NET 9.0  | 29.5758 ns | 0.6365 ns | 42.26 |    5 |         - |
| SendRequest_MediatR                      | .NET 9.0  | 51.0341 ns | 1.0445 ns | 72.92 |    6 |     264 B |

#### [Benchmarks.Large](./benchmarks/Benchmark.Large)

This benchmark tests the various mediator implementations in the face of 999 request/response handlers.

| Method                                   | Runtime   | Mean        | Error     | Ratio  | Rank | Allocated |
|----------------------------------------- |---------- |------------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline                     | .NET 10.0 |   0.5540 ns | 0.0175 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 |  11.1447 ns | 0.0632 ns |  20.13 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 |  11.8685 ns | 0.0499 ns |  21.44 |    3 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 |  12.7938 ns | 0.0772 ns |  23.11 |    4 |         - |
| SendRequest_Mediator                     | .NET 10.0 |  22.6308 ns | 0.0894 ns |  40.89 |    5 |         - |
| SendRequest_MediatR                      | .NET 10.0 |  42.3911 ns | 0.3226 ns |  76.59 |    6 |     200 B |
| SendRequest_IMediator                    | .NET 10.0 | 423.9941 ns | 2.0621 ns | 766.00 |    7 |         - |
|                                          |           |             |           |        |      |           |
| SendRequest_Baseline                     | .NET 9.0  |   0.9383 ns | 0.0184 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  |  11.1246 ns | 0.0463 ns |  11.86 |    2 |         - |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  |  11.1377 ns | 0.0969 ns |  11.87 |    2 |         - |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  |  14.0591 ns | 0.0555 ns |  14.99 |    3 |         - |
| SendRequest_Mediator                     | .NET 9.0  |  22.3005 ns | 0.0420 ns |  23.77 |    4 |         - |
| SendRequest_MediatR                      | .NET 9.0  |  49.7489 ns | 0.3809 ns |  53.03 |    5 |     264 B |
| SendRequest_IMediator                    | .NET 9.0  | 442.8573 ns | 4.3888 ns | 472.08 |    6 |         - |

#### [Benchmarks.Behaviors](./benchmarks/Benchmark.Behaviors)

This benchmark tests a more realistic scenario of using 1 behavior and 1 service.

| Method                                   | Runtime   | Mean      | Error    | Ratio | Rank | Allocated |
|----------------------------------------- |---------- |----------:|---------:|------:|-----:|----------:|
| SendRequest_Baseline                     | .NET 10.0 |  45.77 ns | 0.696 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateSealedHandler       | .NET 10.0 |  58.53 ns | 0.369 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateHandler_Abstraction | .NET 10.0 |  58.55 ns | 0.322 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateStaticHandler       | .NET 10.0 |  59.56 ns | 1.148 ns |  1.30 |    2 |      40 B |
| SendRequest_Mediator                     | .NET 10.0 |  89.50 ns | 0.430 ns |  1.96 |    3 |      40 B |
| SendRequest_IMediator                    | .NET 10.0 |  92.54 ns | 0.493 ns |  2.02 |    4 |      40 B |
| SendRequest_MediatR                      | .NET 10.0 | 186.40 ns | 1.175 ns |  4.07 |    5 |     496 B |
|                                          |           |           |          |       |      |           |
| SendRequest_Baseline                     | .NET 9.0  |  48.00 ns | 0.352 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateStaticHandler       | .NET 9.0  |  61.62 ns | 0.536 ns |  1.28 |    2 |      40 B |
| SendRequest_ImmediateSealedHandler       | .NET 9.0  |  62.75 ns | 0.533 ns |  1.31 |    2 |      40 B |
| SendRequest_ImmediateHandler_Abstraction | .NET 9.0  |  64.75 ns | 0.608 ns |  1.35 |    2 |      40 B |
| SendRequest_Mediator                     | .NET 9.0  |  91.79 ns | 0.455 ns |  1.91 |    3 |      40 B |
| SendRequest_IMediator                    | .NET 9.0  | 101.97 ns | 0.291 ns |  2.12 |    4 |      40 B |
| SendRequest_MediatR                      | .NET 9.0  | 195.75 ns | 3.187 ns |  4.08 |    5 |     560 B |
