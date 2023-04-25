using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class ProdutoBancoServices : IProdutoBancoServices
    {
        private readonly IProdutoBancoRepository _produtobancoRepository;
        public ProdutoBancoServices(IProdutoBancoRepository produtobancoRepository)
        {
            this._produtobancoRepository = produtobancoRepository;
        }

    }
}
