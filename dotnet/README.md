# Progress

- [ ] **User subscription endpoint**
- [ ] **Validation of input**
- [ ] **Persistence**
- [ ] **Migrations / schema management**
- [ ] **Unit tests for domain logic**
- [ ] **Integration tests**
- [ ] **Property-based tests**
- [ ] **Health check endpoint**
- [ ] **Configuration management**
- [ ] **Observability / Logging**
- [ ] **Error handling / graceful failures**
- [ ] **Dockerization**
- [ ] **Local development orchestration**
- [ ] **CI / CD setup**
- [ ] **API documentation / description**
- [ ] **Metrics / Monitoring**

## Project Structure

The solution is divided into several projects in attempt to maintain a clean separation of concerns, and follow clean architecture principles.

- **dotnet.Domain**: Core business logic, entities, and interfaces.
- **dotnet.Application**: Use cases, application services, and DTOs.
- **dotnet.Infrastructure**: Implementation of interfaces for external systems (e.g., database, email).
- **dotnet.Api**: Entry point, HTTP layer, and controller/endpoint definitions.
- **dotnet.Tests.***: XUnit test projects for each layer.

## How it was Generated

This structure was generated using the .NET CLI with the following commands:

```bash
# Create solution
dotnet new sln -n dotnet

# Create projects
dotnet new classlib -n dotnet.Domain
dotnet new classlib -n dotnet.Application
dotnet new classlib -n dotnet.Infrastructure
dotnet new webapi -n dotnet.Api
dotnet new xunit -n dotnet.Tests.Domain
dotnet new xunit -n dotnet.Tests.Application
dotnet new xunit -n dotnet.Tests.Api

# Add projects to solution
dotnet sln add **/*.csproj

# Add project references
dotnet add dotnet.Application/dotnet.Application.csproj reference dotnet.Domain/dotnet.Domain.csproj
dotnet add dotnet.Infrastructure/dotnet.Infrastructure.csproj reference dotnet.Application/dotnet.Application.csproj
dotnet add dotnet.Api/dotnet.Api.csproj reference dotnet.Application/dotnet.Application.csproj
dotnet add dotnet.Api/dotnet.Api.csproj reference dotnet.Infrastructure/dotnet.Infrastructure.csproj

# Add test references
dotnet add dotnet.Tests.Domain/dotnet.Tests.Domain.csproj reference dotnet.Domain/dotnet.Domain.csproj
dotnet add dotnet.Tests.Application/dotnet.Tests.Application.csproj reference dotnet.Application/dotnet.Application.csproj
dotnet add dotnet.Tests.Api/dotnet.Tests.Api.csproj reference dotnet.Api/dotnet.Api.csproj

# Create domain-specific folders
mkdir -p dotnet.Domain/Domain dotnet.Application/Services dotnet.Infrastructure/Infrastructure dotnet.Api/Endpoints
```

## Getting Started

To build the solution:
```bash
dotnet build
```

To run the API:
```bash
dotnet run --project dotnet.Api/dotnet.Api.csproj
```

To run tests:
```bash
dotnet test
```
