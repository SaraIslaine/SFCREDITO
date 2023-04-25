using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class SituacaoPropostaRepository : BaseRepository<SituacaoProposta>, ISituacaoPropostaRepository
    {
        private readonly SFcreditoContext context;

        public SituacaoPropostaRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
