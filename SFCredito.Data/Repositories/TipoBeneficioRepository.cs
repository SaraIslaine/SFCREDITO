using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class TipoBeneficioRepository : BaseRepository<TipoBeneficio>, ITipoBeneficioRepository
    {
        private readonly SFcreditoContext context;

        public TipoBeneficioRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
