using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuiteController : ControllerBase
    {
        private static List<Suite> _suites = new();

        [HttpPost]
        public IActionResult Adicionar([FromBody] Suite suite)
        {
            _suites.Add(suite);
            return Created("", suite);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_suites);
        }
    }
}