using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class TelaTransacaoServices : ITelaTransacaoServices
    {
        private readonly ITelaTransacaoRepository _telatransacaoRepository;
        public TelaTransacaoServices(ITelaTransacaoRepository telatransacaoRepository)
        {
            this._telatransacaoRepository = telatransacaoRepository;
        }

    }
}
