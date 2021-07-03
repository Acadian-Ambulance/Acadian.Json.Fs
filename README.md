# Acadian.Json.Fs

Adds extensions for Newtonsoft.Json

## Dependencies
- dotnet v5.0.103

## Development Dependencies
- just 0.9.5 - command runner
- fantomas v4.4.0 - code formatting tool (dotnet tool install -g fantomas-tool)
- dotnet fsharplint - code linter (dotnet tool install -g dotnet-fsharplint)

# Development Tools
- VS Code
- VS Code Extension ionide.ionide-fsharp

## Module Extensions

Adds JsonConverters:
  - OptionConverter

  Ex:
  > let jsons = JsonConvert.SerializeObject(items, OptionConverter())

