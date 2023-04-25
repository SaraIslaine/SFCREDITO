using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class PerfilServices : IPerfilServices
    {
        private readonly IPerfilRepository _perfilRepository;
        public PerfilServices(IPerfilRepository perfilRepository)
        {
            this._perfilRepository = perfilRepository;
        }

        public Task Adcionar(Perfil perfil)
        {
            _perfilRepository.Adicionar(perfil);

        return  _perfilRepository.Salvar();

        }
        
        public async Task<List<Perfil>> Listar()
        {
            var perfies = await _perfilRepository.ListarTodos(0, 0);

            return perfies.ToList();
        }
        }
        

}