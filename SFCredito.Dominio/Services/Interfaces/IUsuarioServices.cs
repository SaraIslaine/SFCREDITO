using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Dominio.Services.Interfaces
{
    public interface IUsuarioServices
    {
        void Adicionar(Usuario usuario);
        Usuario Edite(Usuario usuario);
        void Deletar(long id);
        Usuario SenhaAlterada(Usuario usuario);
        Task<Usuario> ObterUsuario(long id);
        Task<List<Usuario>>? GetAll();
    }
}
