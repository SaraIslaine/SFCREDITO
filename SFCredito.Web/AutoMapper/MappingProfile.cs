using AutoMapper;
using SFCredito.Dominio.Entidades;
using SFCredito.Web.Models;

namespace SFCredito.Web.AutoMapper
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Perfil, PerfiilModel>().ReverseMap();
            CreateMap<Usuario, UsuarioModel>().ReverseMap();
            CreateMap<Empresa, EmpresaModel>().ReverseMap();
        }


    }
}
