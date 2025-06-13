//using Microsoft.VisualStudio.TestPlatform.TestHost;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http.Json;
//using System.Threading.Tasks;

//namespace HotelReservation.Tests.Integration
//{
//    public class ReservaControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
//    {
//        private readonly HttpClient _client;

//        public ReservaControllerTests(CustomWebApplicationFactory<Program> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task PostReserva_Valida_DeveRetornarCreated()
//        {
//            var reserva = new Reserva
//            {
//                DiasReservados = 5,
//                Suite = new Suite { TipoSuite = "Executiva", Capacidade = 2, ValorDiaria = 200m },
//                Hospedes = new List<Pessoa>
//            {
//                new Pessoa { Nome = "Alice" },
//                new Pessoa { Nome = "Bob" }
//            }
//            };

//            var response = await _client.PostAsJsonAsync("/api/reserva", reserva);

//            response.StatusCode.Should().Be(HttpStatusCode.Created);
//        }

//        [Fact]
//        public async Task PostReserva_HospedesExcedemCapacidade_DeveRetornarBadRequest()
//        {
//            var reserva = new Reserva
//            {
//                DiasReservados = 3,
//                Suite = new Suite { TipoSuite = "Padrão", Capacidade = 1, ValorDiaria = 100m },
//                Hospedes = new List<Pessoa>
//            {
//                new Pessoa { Nome = "Fulano" },
//                new Pessoa { Nome = "Beltrano" }
//            }
//            };

//            var response = await _client.PostAsJsonAsync("/api/reserva", reserva);

//            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
//        }
//    }
//}