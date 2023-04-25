using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly SFcreditoContext context;

        public ProdutoRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
