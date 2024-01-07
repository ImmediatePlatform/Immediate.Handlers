## Release 1.0

### New Rules

| Rule ID | Category | Severity | Notes                                                                                        |
|---------|----------|----------|----------------------------------------------------------------------------------------------|
| IH0001  | Usage    | Error    | Handler annotated classes must implement a HandleAsync method                                |
| IH0002  | Usage    | Error    | Handler HandleAsync method must return Task<T>                                               |
| IH0003  | Usage    | Error    | Handler HandleAsync method must have a Request type and CancellationToken as it's parameters |