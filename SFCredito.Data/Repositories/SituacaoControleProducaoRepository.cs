using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class SituacaoControleProducaoRepository : BaseRepository<SituacaoControleProducao>, ISituacaoControleProducaoRepository
    {
        private readonly SFcreditoContext context;

        public SituacaoControleProducaoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
