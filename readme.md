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
public static partial class GetUsersQuery
{
    public record Query;

    private static ValueTask<IEnumerable<User>> HandleAsync(
        Query _,
        UsersService usersService,
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
public static partial class CreateUserCommand
{
    public record Command(string Email);

    private static async ValueTask HandleAsync( 
        Command command,
        UsersService usersService,
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
public static class GetUsersQuery
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

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
```

#### [Benchmarks.Simple](./benchmarks/Benchmark.Simple)

This benchmark tests the various mediator implementations with a single request/response handler.

| Method                       | Mean       | Error     | Ratio | Rank | Allocated |
|----------------------------- |-----------:|----------:|------:|-----:|----------:|
| SendRequest_Baseline         |  0.6618 ns | 0.0127 ns |  1.00 |    1 |         - |
| SendRequest_IHandler         | 14.0497 ns | 0.0753 ns | 21.23 |    2 |         - |
| SendRequest_ImmediateHandler | 14.9493 ns | 0.0818 ns | 22.59 |    3 |         - |
| SendRequest_Mediator         | 22.0218 ns | 0.0684 ns | 33.28 |    4 |         - |
| SendRequest_IMediator        | 26.8625 ns | 0.1428 ns | 40.60 |    5 |         - |
| SendRequest_MediatR          | 47.5135 ns | 0.4161 ns | 71.81 |    6 |     192 B |

#### [Benchmarks.Large](./benchmarks/Benchmark.Large)

This benchmark tests the various mediator implementations in the face of 999 request/response handlers.

| Method                       | Mean        | Error     | Ratio  | Rank | Allocated |
|----------------------------- |------------:|----------:|-------:|-----:|----------:|
| SendRequest_Baseline         |   0.6257 ns | 0.0202 ns |   1.00 |    1 |         - |
| SendRequest_ImmediateHandler |  11.2358 ns | 0.0395 ns |  17.97 |    2 |         - |
| SendRequest_IHandler         |  14.0575 ns | 0.0652 ns |  22.49 |    3 |         - |
| SendRequest_Mediator         |  22.0874 ns | 0.0534 ns |  35.33 |    4 |         - |
| SendRequest_MediatR          |  48.3577 ns | 0.2402 ns |  77.35 |    5 |     192 B |
| SendRequest_IMediator        | 420.2067 ns | 4.5092 ns | 672.17 |    6 |         - |

#### [Benchmarks.Behaviors](./benchmarks/Benchmark.Behaviors)

This benchmark tests a more realistic scenario of using 1 behavior and 1 service.

| Method                       | Mean      | Error    | Ratio | Rank | Allocated |
|----------------------------- |----------:|---------:|------:|-----:|----------:|
| SendRequest_Baseline         |  47.83 ns | 0.160 ns |  1.00 |    1 |      40 B |
| SendRequest_ImmediateHandler |  62.67 ns | 0.350 ns |  1.31 |    2 |      40 B |
| SendRequest_IHandler         |  63.59 ns | 0.218 ns |  1.33 |    2 |      40 B |
| SendRequest_Mediator         |  91.53 ns | 0.292 ns |  1.91 |    3 |      40 B |
| SendRequest_IMediator        | 100.73 ns | 0.396 ns |  2.11 |    4 |      40 B |
| SendRequest_MediatR          | 188.54 ns | 0.785 ns |  3.94 |    5 |     560 B |
