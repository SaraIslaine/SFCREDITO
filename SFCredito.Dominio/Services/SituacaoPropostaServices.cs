using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class SituacaoPropostaServices : ISituacaoPropostaServices
    {
        private readonly ISituacaoPropostaRepository _situacaopropostaRepository;
        public SituacaoPropostaServices(ISituacaoPropostaRepository situacaopropostaRepository)
        {
            this._situacaopropostaRepository = situacaopropostaRepository;
        }

    }
}
