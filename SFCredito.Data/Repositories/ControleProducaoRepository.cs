using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class ControleProducaoRepository : BaseRepository<ControleProducao>, IControleProducaoRepository
    {
        private readonly SFcreditoContext context;

        public ControleProducaoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
