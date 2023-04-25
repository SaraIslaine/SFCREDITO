using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class PreAgendamentoServices : IPreAgendamentoServices
    {
        private readonly IPreAgendamentoRepository _preagendamentoRepository;
        public PreAgendamentoServices(IPreAgendamentoRepository preagendamentoRepository)
        {
            this._preagendamentoRepository = preagendamentoRepository;
        }

    }
}
