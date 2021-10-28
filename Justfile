# vim: filetype=bash

format:
  which fantomas && find . -type f -name "*.fs" -not -path "*/obj/*" -not -path "*/bin/*" -exec fantomas "{}" \;

lint:
  find . -name "*.fsproj" -not -path "*/obj/*" -not -path "*/bin/*" -exec dotnet fsharplint lint "{}" \;

build:
  dotnet restore --interactive .
  dotnet build

run:
  dotnet run

test:
  dotnet test

