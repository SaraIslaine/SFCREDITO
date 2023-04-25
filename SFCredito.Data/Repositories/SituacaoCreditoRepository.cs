using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class SituacaoCreditoRepository : BaseRepository<SituacaoCredito>, ISituacaoCreditoRepository
    {
        private readonly SFcreditoContext context;

        public SituacaoCreditoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
