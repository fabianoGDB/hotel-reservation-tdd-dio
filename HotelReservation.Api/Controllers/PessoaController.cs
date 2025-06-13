using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private static List<Pessoa> _pessoas = new();

        [HttpPost]
        public IActionResult Adicionar([FromBody] Pessoa pessoa)
        {
            _pessoas.Add(pessoa);
            return Created("", pessoa);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_pessoas);
        }
    }
}