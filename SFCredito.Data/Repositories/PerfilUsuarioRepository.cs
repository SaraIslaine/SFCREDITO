using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class PerfilUsuarioRepository : BaseRepository<PerfilUsuario>, IPerfilUsuarioRepository
    {
        private readonly SFcreditoContext context;

        public PerfilUsuarioRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
