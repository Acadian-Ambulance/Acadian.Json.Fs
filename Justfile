format:
  which fantomas && find . -type f -name "*.fs" -not -path "*/obj/*" -not -path "*/bin/*" -exec fantomas "{}" \; && find . -type f -name "*.fs" -not -path "*/obj/*" -not -path "*/bin/*" -exec dos2unix "{}" \;

lint:
  find . -name "*.fsproj" -not -path "*/obj/*" -not -path "*/bin/*" -exec dotnet fsharplint lint "{}" \;

