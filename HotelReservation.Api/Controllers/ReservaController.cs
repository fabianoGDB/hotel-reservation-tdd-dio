using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private static List<Reserva> _reservas = new();

        [HttpPost]
        public IActionResult CriarReserva([FromBody] Reserva reserva)
        {
            if (reserva.Hospedes.Count > reserva.Suite.Capacidade)
                return BadRequest("Número de hóspedes excede a capacidade da suíte.");

            _reservas.Add(reserva);
            return Created("", new
            {
                reserva.DiasReservados,
                Hospedes = reserva.Hospedes.Count,
                Suite = reserva.Suite.TipoSuite,
                Total = reserva.CalcularValorDiaria()
            });
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_reservas);
        }
    }
}