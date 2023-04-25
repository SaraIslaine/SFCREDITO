
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class SituacaoCreditoServices : ISituacaoCreditoServices
    {
        private readonly ISituacaoCreditoRepository _situacaocreditoRepository;
        public SituacaoCreditoServices(ISituacaoCreditoRepository situacaocreditoRepository)
        {
            this._situacaocreditoRepository = situacaocreditoRepository;
        }

    }
}

