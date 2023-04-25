using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class ProdutoBancoRepository : BaseRepository<ProdutoBanco>, IProdutoBancoRepository
    {
        private readonly SFcreditoContext context;

        public ProdutoBancoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
