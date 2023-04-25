using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class TelefoneServices : ITelefoneServices
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneServices(ITelefoneRepository telefoneRepository)
        {
            this._telefoneRepository = telefoneRepository;
        }

    }
}
