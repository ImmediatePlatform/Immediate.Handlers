# Immediate.Handlers.Analyzers

## IHR0004: RenderMode attribute must be set to a valid RenderMode

An invalid value on the `RenderMode` attribute on the assembly or a Handler is unsupported and will lead to compilation
errors. Removing the attribute will restore the default of `RenderMode.Normal`, or setting the value to a valid value
will correct the issue.

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---

## IHR0005: Handler class must not be nested in another type

Nesting the handler class within another type is unsupported, since it creates difficulties with scoping on the source
generated side. While it would technically be possible in certain circumstances (containing type being partial e.g.)
it is not supported for now.

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Error|
|CodeFix|False|
---
