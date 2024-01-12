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

## IHR0010: Behaviors must not be repeated in a pipeline

Behaviors are not reentrant, and must not be specified more than once in a single pipeline. 

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---
