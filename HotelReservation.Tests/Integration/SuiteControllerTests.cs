//using System.Net;
//using System.Net.Http.Json;
//using Microsoft.VisualStudio.TestPlatform.TestHost;

//namespace HotelReservation.Tests.Integration
//{
//    public class SuiteControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
//    {
//        private readonly HttpClient _client;

//        public SuiteControllerTests(CustomWebApplicationFactory<Program> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task PostSuite_DeveCriarSuite()
//        {
//            var suite = new Suite { TipoSuite = "Luxo", Capacidade = 2, ValorDiaria = 150m };

//            var response = await _client.PostAsJsonAsync("/api/suite", suite);

//            response.StatusCode.Should().Be(HttpStatusCode.Created);
//        }

//        [Fact]
//        public async Task GetSuites_DeveRetornarLista()
//        {
//            var response = await _client.GetAsync("/api/suite");

//            response.StatusCode.Should().Be(HttpStatusCode.OK);
//        }
//    }
//}