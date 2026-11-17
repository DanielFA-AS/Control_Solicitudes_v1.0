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
            var solicitudTodas = await _context.Solicituds
            .FromSql($"EXECUTE dbo.ConsultaTodasSolicitudes")
            .ToListAsync();
            return Ok(solicitudTodas);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var solicitudID = await _context.Solicituds
            .FromSql($"EXECUTE dbo.ConsultaPorID @Id={id}")
            .ToListAsync();
            if (solicitudID.Count == 0)
            {
                return NotFound();
            }
            return Ok(solicitudID.First());
        }

        [HttpGet("estado/{id:int}")]
        public async Task<IActionResult> ObtenerPorEstado(int id)
        {
            var solicitudEstado = await _context.Solicituds
            .FromSql($"EXECUTE dbo.ConsultaPorEstado @Estado={id}")
            .ToListAsync();
            return Ok(solicitudEstado);
        }
    }
}
