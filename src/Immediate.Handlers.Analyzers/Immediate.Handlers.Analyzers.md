# Immediate.Handlers.Analyzers

## IHR0001: Handler method must exist

Handler classes must define a method with the signature `private static Task<T> HandleAsync(TRequest command, CancellationToken)`.

| Item     | Value            |
|----------|------------------|
| Category | ImmediateHandler |
| Enabled  | True             |
| Severity | Error            |
| CodeFix  | True             |
---

## IHR0002: Handler method must return Task<T>

Handler methods must return a `Task<T>`

| Item     | Value            |
|----------|------------------|
| Category | ImmediateHandler |
| Enabled  | True             |
| Severity | Error            |
| CodeFix  | False            |
---

## IHR0003: Handler method must receive correct parameters

Handler methods must receive a `TRequest` and a `CancellationToken` as parameters. Any services can be injected automatically
by passing them in as parameters to the `HandleAsync` method of the handler class, between the `TRequest` and `CancellationToken` parameters.

| Item     | Value            |
|----------|------------------|
| Category | ImmediateHandler |
| Enabled  | True             |
| Severity | Error            |
| CodeFix  | False            |
---

## IHR0004: RenderMode attribute must be set to a valid RenderMode

An invalid value on the `RenderMode` attribute on the assembly or a Handler is unsupported and will lead to compilation
errors. Removing the attribute will restore the default of `RenderMode.Normal`, or setting the value to a valid value
will correct the issue.

| Item     | Value            |
|----------|------------------|
| Category | ImmediateHandler |
| Enabled  | True             |
| Severity | Error            |
| CodeFix  | False            |
---

## IHR0005: Handler class must not be nested in another type

Nesting the handler class within another type is unsupported, since it creates difficulties with scoping on the source
generated side. While it would technically be possible in certain circumstances (containing type being partial e.g.)
it is not supported for now.

| Item     | Value            |
|----------|------------------|
| Category | ImmediateHandler |
| Enabled  | True             |
| Severity | Error            |
| CodeFix  | False            |
---

## IHR0009: Handler class should define a Command or Query record

Handler classes should define a Command or Query record, which will be used as the request type for the handler. 

| Item     | Value            |
|----------|------------------|
| Category | ImmediateHandler |
| Enabled  | True             |
| Severity | Warning          |
| CodeFix  | True             |
---

## IHR0006: Behaviors must inherit from `Behavior<,>`

In order to be properly called as part of a pipeline, a behavior must inherit from the `Behavior<,>` class.

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---

## IHR0007: Behaviors must have two generic types

All behaviors must have two generic parameters, for `TRequest` and `TResponse`. Without these parameters, it is not
possible to bind the behavior to the target request and response types.

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---

## IHR0008: Behavior must be referenced with unbound generic

Behaviors must be referenced using the unbound generic syntax. Referencing a generic type using a specific type will
introduce inconsistencies in connecting multiple behaviors in a pipeline. 

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---
