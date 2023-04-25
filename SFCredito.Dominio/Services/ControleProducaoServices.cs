using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class ControleProducaoServices : IControleProducaoServices
    {
        private readonly IControleProducaoRepository _controleproducaoRepository;
        public ControleProducaoServices(IControleProducaoRepository controleproducaoRepository)
        {
            this._controleproducaoRepository = controleproducaoRepository;
        }

        
    }
}