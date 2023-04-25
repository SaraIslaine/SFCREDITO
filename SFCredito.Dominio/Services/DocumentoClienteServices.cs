using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class DocumentoClienteServices : IDocumentoClienteServices
    {
        private readonly IDocumentoClienteRepository _documentoClienteRepository;
        public DocumentoClienteServices(IDocumentoClienteRepository documentoClienteRepository)
        {
            this._documentoClienteRepository = documentoClienteRepository;
        }

    }
}
