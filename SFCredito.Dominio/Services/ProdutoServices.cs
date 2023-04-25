using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class ProdutoServices : IProdutoServices
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoServices(IProdutoRepository produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }

    }
}
