using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class BancoRepository : BaseRepository<Banco>, IBancoRepository
    {
        private readonly SFcreditoContext context;

        public BancoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
