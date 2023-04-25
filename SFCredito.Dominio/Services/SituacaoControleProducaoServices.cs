using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class SituacaoControleProducaoServices : ISituacaoControleProducaoServices
    {
        private readonly ISituacaoControleProducaoRepository _situacaocontroleproducaoRepository;
        public SituacaoControleProducaoServices(ISituacaoControleProducaoRepository situacaocontroleproducaoRepository)
        {
            this._situacaocontroleproducaoRepository = situacaocontroleproducaoRepository;
        }

    }
}
