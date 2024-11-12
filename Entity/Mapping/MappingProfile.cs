using AutoMapper;
using Entity.DTOs;
using Entity.Models;

namespace Entity.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GrupoDTO, Grupo>();

        }
    }
}
