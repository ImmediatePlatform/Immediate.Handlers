# Immediate.Handlers.Analyzers

## IHR0004: RenderMode attribute must be set to a valid RenderMode

If the `RenderMode` attribute on the assembly or a Handler is set to an invalid value, then no code will be generated.
Removing the attribute will restore the default of `RenderMode.Normal`, or setting the value to a valid value will allow
generation to happen as expected.

|Item|Value|
|-|-|
|Category|ImmediateHandler|
|Enabled|True|
|Severity|Warning|
|CodeFix|False|
---
