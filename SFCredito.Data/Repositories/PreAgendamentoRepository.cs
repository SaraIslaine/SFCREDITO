using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class PreAgendamentoRepository : BaseRepository<PreAgendamento>, IPreAgendamentoRepository
    {
        private readonly SFcreditoContext context;

        public PreAgendamentoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
