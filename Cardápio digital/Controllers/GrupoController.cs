using Entity.DTOs;
using Entity.Interface;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace API.Controllers
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

        [HttpGet("GetListaGrupo")]
        public IActionResult GetListaGrupo()
        {
            var grupo = _grupoContext.GetAll();
            return Ok(grupo);
        }

        [HttpPost("CreateGrupo")]

        public IActionResult CadastrarGrupo([FromBody] GrupoDTO grupoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupo = _mapper.Map<Grupo>(grupoDTO);
            _grupoContext.Create(grupo);
            return Ok("Grupo criado com sucesso.");
        }

        [HttpPut("UpdateGrupo")]

        public IActionResult UpdateGrupo([FromBody] Grupo grupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupoExistente = _grupoContext.VerificaGrupoExistente(grupo.Id);
            if (grupoExistente == null)
            {
                return NotFound("Grupo não encontrado.");
            }

            // Atualiza a entidade existente com os valores do DTO
            _grupoContext.Update(grupo);

            return Ok("Grupo atualizado com sucesso.");

        }

        [HttpGet("GetGrupo")]

        public IActionResult GetGrupo(int id)
        {
            var grupo = _grupoContext.GetById(id);
            return Ok(grupo);
        }
    }
}


