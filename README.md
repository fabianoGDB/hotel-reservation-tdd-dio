# Criar a solução principal

dotnet new sln -n HotelReservation

# Criar a biblioteca de classes para a lógica

dotnet new classlib -n HotelReservation.Core

# Criar o projeto de testes com xUnit

dotnet new xunit -n HotelReservation.Tests

# Adicionar projetos à solução

dotnet sln HotelReservation.sln add HotelReservation.Core/HotelReservation.Core.csproj
dotnet sln HotelReservation.sln add HotelReservation.Tests/HotelReservation.Tests.csproj

# Adicionar referência do projeto de testes à biblioteca principal

dotnet add HotelReservation.Tests/HotelReservation.Tests.csproj reference HotelReservation.Core/HotelReservation.Core.csproj
