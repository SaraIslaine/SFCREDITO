using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class PerfilRepository : BaseRepository<Perfil>, IPerfilRepository
    {
        private readonly SFcreditoContext context;

        public PerfilRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
