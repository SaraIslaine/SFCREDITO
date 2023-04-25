using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class TipoBeneficioServices : ITipoBeneficioServices
    {
        private readonly ITipoBeneficioRepository _tipobeneficioRepository;
        public TipoBeneficioServices(ITipoBeneficioRepository tipobeneficioRepository)
        {
            this._tipobeneficioRepository = tipobeneficioRepository;
        }

      
    }
}