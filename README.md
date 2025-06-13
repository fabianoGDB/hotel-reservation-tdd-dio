# Criar a solução principal

```
dotnet new sln -n HotelReservation
```

# Criar a biblioteca de classes para a lógica

```
dotnet new classlib -n HotelReservation.Core
```

# Criar o projeto de testes com xUnit

```
dotnet new xunit -n HotelReservation.Tests
```

# Adicionar pacotes para teste de integração

```
dotnet new xunit -n HotelReservation.IntegrationTests
dotnet add HotelReservation.IntegrationTests/HotelReservation.IntegrationTests.csproj reference HotelReservation.Api/HotelReservation.Api.csproj
dotnet add HotelReservation.IntegrationTests/HotelReservation.IntegrationTests.csproj package Microsoft.AspNetCore.Mvc.Testing
dotnet add HotelReservation.IntegrationTests/HotelReservation.IntegrationTests.csproj package FluentAssertions
```

# Adicionar projetos à solução

```
dotnet sln HotelReservation.sln add HotelReservation.Core/HotelReservation.Core.csproj
dotnet sln HotelReservation.sln add HotelReservation.Tests/HotelReservation.Tests.csproj
```

# Adicionar referência do projeto de testes à biblioteca principal

```
dotnet add HotelReservation.Tests/HotelReservation.Tests.csproj reference HotelReservation.Core/HotelReservation.Core.csproj
```
