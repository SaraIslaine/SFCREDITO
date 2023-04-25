using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class BancoServices : IBancoServices
    {
        private readonly IBancoRepository _bancoRepository;
        public BancoServices(IBancoRepository bancoRepository)
        {
            this._bancoRepository = bancoRepository;
        }
    }
}