using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Tests.Unit
{
    public class ReservaTests
    {
        [Fact]
        public void CalcularValorDiaria_ReservaComMenosDe10Dias_DeveRetornarValorTotalSemDesconto()
        {
            // Arrange
            var suite = new Suite("Executiva", 2, 150m);
            var reserva = new Reserva(suite, diasReservados: 5);

            var hospedes = new List<Pessoa>
            {
                new Pessoa("Ana"),
                new Pessoa("Bruno")
            };
            reserva.CadastrarHospedes(hospedes);

            // Act
            var valor = reserva.CalcularValorDiaria();

            // Assert
            Assert.Equal(750m, valor); // 5 * 150
        }

        [Fact]
        public void CalcularValorDiaria_ReservaCom10OuMaisDias_DeveAplicarDescontoDe10PorCento()
        {
            // Arrange
            var suite = new Suite("Master", 2, 200m);
            var reserva = new Reserva(suite, diasReservados: 10);

            var hospedes = new List<Pessoa>
            {
                new Pessoa("Carlos")
            };
            reserva.CadastrarHospedes(hospedes);

            // Act
            var valor = reserva.CalcularValorDiaria();

            // Assert
            Assert.Equal(1800m, valor); // 10 * 200 * 0.9
        }

        [Fact]
        public void CadastrarHospedes_MaisQueCapacidadeSuite_DeveLancarExcecao()
        {
            // Arrange
            var suite = new Suite("Padrão", 2, 100m);
            var reserva = new Reserva(suite, diasReservados: 3);

            var hospedes = new List<Pessoa>
            {
                new Pessoa("Pessoa 1"),
                new Pessoa("Pessoa 2"),
                new Pessoa("Pessoa 3") // excede a capacidade
            };

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => reserva.CadastrarHospedes(hospedes));
            Assert.Equal("Número de hóspedes excede a capacidade da suíte.", ex.Message);
        }
    }
}