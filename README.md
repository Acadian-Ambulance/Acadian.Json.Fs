# Acadian.Json.Fs

Adds extensions for Newtonsoft.Json

## Dependencies
- just 0.9.5
- dotnet v5.0.103
- fantomas v4.4.0 (dotnet tool install -g fantomas-tool)
- dotnet fsharplint (dotnet tool install -g dotnet-fsharplint)

## Module Extensions

Adds JsonConverters:
  - OptionConverter

  Ex:
  > let jsons = JsonConvert.SerializeObject(items, OptionConverter())

