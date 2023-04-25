using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class AnalisePropostaRepository : BaseRepository<AnaliseProposta>, IAnalisePropostaRepository
    {
        private readonly SFcreditoContext context;

        public AnalisePropostaRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
