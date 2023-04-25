using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class DocumentoAssinaturaRepository : BaseRepository<DocumentoAssinatura>, IDocumentoAssinaturaRepository
    {
        private readonly SFcreditoContext context;

        public DocumentoAssinaturaRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
