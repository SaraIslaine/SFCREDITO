using SFCredito.Dominio.Entidades;

namespace SFCredito.Dominio.Services.Interfaces
{
    public interface IPerfilServices
    {
        Task Adcionar(Perfil perfil);
        Task<List<Perfil>> Listar();

    }
}
