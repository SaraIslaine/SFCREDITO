using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class CartelaClienteFinanceiraServices : ICartelaClienteFinanceiraServices
    {
        private readonly ICartelaClienteFinanceiraRepository _cartelaClienteFinanceiraRepository;
        public CartelaClienteFinanceiraServices(ICartelaClienteFinanceiraRepository cartelaClienteFinanceiraRepository)
        {
            this._cartelaClienteFinanceiraRepository = cartelaClienteFinanceiraRepository;
        }
    }
}