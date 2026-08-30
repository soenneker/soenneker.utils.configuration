[![](https://img.shields.io/nuget/v/soenneker.utils.configuration.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.configuration/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.configuration/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.configuration/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.configuration.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.configuration/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.configuration/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.configuration/actions/workflows/codeql.yml)

# Soenneker.Utils.Configuration

DI registration for the `IConfigurationUtil` marker service.

## Installation

```bash
dotnet add package Soenneker.Utils.Configuration
```

## Registration

```csharp
using Soenneker.Utils.Configuration.Registrars;

services.AddConfigurationUtilAsSingleton();
```

Scoped registration is also available:

```csharp
services.AddConfigurationUtilAsScoped();
```

`IConfigurationUtil` does not expose configuration operations or wrap `IConfiguration`; resolving it only provides a marker service. Applications that need to read configuration should continue to inject `IConfiguration` or typed options directly.
