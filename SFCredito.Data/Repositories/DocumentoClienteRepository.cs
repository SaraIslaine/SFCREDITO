using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class DocumentoClienteRepository : BaseRepository<DocumentoCliente>, IDocumentoClienteRepository
    {
        private readonly SFcreditoContext context;

        public DocumentoClienteRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
