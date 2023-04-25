using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class PerfilUsuarioServices : IPerfilUsuarioServices
    {
        private readonly IPerfilUsuarioRepository _perfilusuarioRepository;
        public PerfilUsuarioServices(IPerfilUsuarioRepository perfilusuarioRepository)
        {
            this._perfilusuarioRepository = perfilusuarioRepository;
        }

    }
}
