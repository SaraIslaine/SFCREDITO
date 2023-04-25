using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class AnalisePropostaServices : IAnalisePropostaServices
    {
        private readonly IAnalisePropostaRepository _analisePropostaRepository;
        public AnalisePropostaServices(IAnalisePropostaRepository analisePropostaRepository)
        {
            this._analisePropostaRepository = analisePropostaRepository;
        }
    }
}