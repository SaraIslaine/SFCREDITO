using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteServices(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }


         
    }
}