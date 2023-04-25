using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class CartelaClienteFinanceiraRepository : BaseRepository<CartelaClienteFinanceira>, ICartelaClienteFinanceiraRepository
    {
        private readonly SFcreditoContext context;

        public CartelaClienteFinanceiraRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
