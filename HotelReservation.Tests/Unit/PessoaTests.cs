using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Tests.Unit
{
    public class PessoaTest
    {
        [Fact]
        public void Constructor_ValidName_ShouldCreatePessoaInstance()
        {
            // Arrange
            string nome = "Fabiano";

            // Act
            var pessoa = new Pessoa(nome);

            // Assert
            Assert.Equal(nome, pessoa.Nome);
        }

        [Fact]
        public void Constructor_NullName_ShouldThrowArgumentNullException()
        {
            // Arrange
            string nome = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Pessoa(nome));
        }
    }
}