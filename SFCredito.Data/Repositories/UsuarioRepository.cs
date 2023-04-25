using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly SFcreditoContext context;

        public UsuarioRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
