using Cardapio_digital.Entity.Context;
using Cardapio_digital.Entity.Interface;
using Cardapio_digital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cardapio_digital.Controllers
{
    [ApiController]
    [Route("Grupo")]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoRepository _grupoContext;

        // Altere o nome do parâmetro para evitar conflito
        public GrupoController(IGrupoRepository grupoContext)
        {
            _grupoContext = grupoContext ?? throw new ArgumentNullException(nameof(grupoContext));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var grupo = _grupoContext.GetAll();
            return Ok(grupo);
        }

        [HttpPost("Cadastrar-Grupo")]

        public IActionResult CadastrarProduto([FromBody] Grupo grupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _grupoContext.Create(grupo);
            return Ok("Grupo criado com sucesso.");
        }
    }
}


