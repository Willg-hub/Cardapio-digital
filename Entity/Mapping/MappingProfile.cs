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
            CreateMap<Grupo, GrupoDTO>()
                .ForMember(dest => dest.ListaProdutos, opt => opt.MapFrom(src => src.ListaProdutos));
            CreateMap<ProdutoDTO, Produto>();

            CreateMap<Produto, ProdutoDTO>();

        }
    }
}
