using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class SimulacaoBancoRepository : BaseRepository<SimulacaoBanco>, ISimulacaoBancoRepository
    {

        private readonly SFcreditoContext context;

        public SimulacaoBancoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
