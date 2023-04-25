using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class DigitacaoRepository : BaseRepository<Digitacao>, IDigitacaoRepository
    {
        private readonly SFcreditoContext context;

        public DigitacaoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
