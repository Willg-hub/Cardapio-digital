using AutoMapper;
using Cardapio_digital.Entity.DTOs;
using Cardapio_digital.Entity.Models;

namespace Cardapio_digital.Entity.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<GrupoDTO, Grupo>();

        }
    }
}
