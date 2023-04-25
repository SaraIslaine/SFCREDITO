using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class SimulacaoServices : ISimulacaoServices
    {
        private readonly ISimulacaoRepository _simulacaoRepository;
        public SimulacaoServices(ISimulacaoRepository simulacaoRepository)
        {
            this._simulacaoRepository = simulacaoRepository;
        }

    }
}
