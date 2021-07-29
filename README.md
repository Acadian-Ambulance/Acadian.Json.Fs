# Acadian.Json.Fs

Adds extensions for Newtonsoft.Json for FSharp

## Json Converters

All converters require these imports:

```
open Newtonsoft.Json
open Acadian.Json.Fs.JsonConverters
```

- OptionConverter - Converts option types to nullable as expected in jsons

  Ex:
  ```
  let jsons = JsonConvert.SerializeObject(items, OptionConverter())
  ```

## Dependencies
- dotnet v5.0.103

## Development Dependencies
- just (command runner) v0.9.9
- fantomas v4.4.0 - code formatting tool (dotnet tool install -g fantomas-tool)
- dotnet fsharplint - code linter (dotnet tool install -g dotnet-fsharplint)

# Development Tools
- VS Code
- VS Code Extension ionide.ionide-fsharp

# Building/Running/Testing
- Uses dotnet cli
Ex: To run tests
> dotnet test

