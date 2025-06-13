//using Microsoft.VisualStudio.TestPlatform.TestHost;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http.Json;
//using System.Threading.Tasks;

//namespace HotelReservation.Tests.Integration
//{
//    public class PessoaControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
//    {
//        private readonly HttpClient _client;

//        public PessoaControllerTests(CustomWebApplicationFactory<Program> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task PostPessoa_DeveCriarPessoa()
//        {
//            var pessoa = new Pessoa { Nome = "Fabiano" };

//            var response = await _client.PostAsJsonAsync("/api/pessoa", pessoa);

//            response.StatusCode.Should().Be(HttpStatusCode.Created);
//        }

//        [Fact]
//        public async Task GetPessoas_DeveRetornarLista()
//        {
//            var response = await _client.GetAsync("/api/pessoa");

//            response.StatusCode.Should().Be(HttpStatusCode.OK);
//        }
//    }
//}