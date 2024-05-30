# Immediate.Handlers.Analyzers

## IHR0001: Handler method must exist

Handler classes must define a method with the signature `private static ValueTask<T> HandleAsync(TRequest command, CancellationToken)`.

| Item     | Value            |
|----------|------------------|
| Category | ImmediateHandler |
| Enabled  | True             |
| Severity | Error            |
| CodeFix  | True             |
---

## IHR0002: Handler method must return ValueTask<T>

Handler methods must return a `ValueTask<T>`

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

## IHR0009: Handler method must be static

Handler method must be static, in order to be correctly referenced by the handler system.

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---

## IHR0010: Handler method must be unique

If both `Handle` and `HandleAsync` are provided, it will not be possible to identify which is the correct handler
method. Only can be provided.

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---
