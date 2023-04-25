using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class TransacaoPerfilRepository : BaseRepository<TransacaoPerfil>, ITransacaoPerfilRepository
    {
        private readonly SFcreditoContext context;

        public TransacaoPerfilRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
