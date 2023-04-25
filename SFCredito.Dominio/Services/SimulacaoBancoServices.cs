using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class SimulacaoBancoServices : ISimulacaoBancoServices
    {
        private readonly ISimulacaoBancoRepository _simulacaobancoRepository;
        public SimulacaoBancoServices(ISimulacaoBancoRepository simulacaobancoRepository)
        {
            this._simulacaobancoRepository = simulacaobancoRepository;
        }

    }
}
