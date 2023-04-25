using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class SimulacaoRepository : BaseRepository<Simulacao>, ISimulacaoRepository
    {

        private readonly SFcreditoContext context;

        public SimulacaoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
