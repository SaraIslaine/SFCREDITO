using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class DocumentoAssinaturaServices : IDocumentoAssinaturaServices
    {
        private readonly IDocumentoAssinaturaRepository _documentoassinaturaRepository;
        public DocumentoAssinaturaServices(IDocumentoAssinaturaRepository documentoassinaturaRepository)
        {
            this._documentoassinaturaRepository = documentoassinaturaRepository;
        }

        
    }
}