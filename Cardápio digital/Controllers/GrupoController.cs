using AutoMapper;
using Cardapio_digital.Entity.Context;
using Cardapio_digital.Entity.DTOs;
using Cardapio_digital.Entity.Interface;
using Cardapio_digital.Entity.Mapping;
using Cardapio_digital.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cardapio_digital.Controllers
{
    [ApiController]
    [Route("Grupo")]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoRepository _grupoContext;
        private readonly IMapper _mapper;

        // Altere o nome do parâmetro para evitar conflito
        public GrupoController(IGrupoRepository grupoContext, IMapper mapper)
        {
            _grupoContext = grupoContext ?? throw new ArgumentNullException(nameof(grupoContext));
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var grupo = _grupoContext.GetAll();
            return Ok(grupo);
        }

        [HttpPost("Cadastrar-Grupo")]

        public IActionResult CadastrarProduto([FromBody] GrupoDTO grupoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupo = _mapper.Map<Grupo>(grupoDTO);
            _grupoContext.Create(grupo);
            return Ok("Grupo criado com sucesso.");
        }
    }
}


