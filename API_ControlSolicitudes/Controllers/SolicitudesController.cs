using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_ControlSolicitudes.Data;

namespace API_ControlSolicitudes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        private readonly ControlSolicitudesContext _context;

        public SolicitudesController(ControlSolicitudesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodas()
        {
            // Consulta a la base de datos.

            // Retornar resultado.
        }
    }
}
