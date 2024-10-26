using Cardapio_digital.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace Cardapio_digital.Controllers
{
    [ApiController]
    [Route("Grupo")]
    public class GrupoController : ControllerBase
    {
        private readonly PgContext _context;

        public GrupoController(PgContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var grupo = _context.Grupo.ToList();
            return Ok(grupo);
        }
    }
}

