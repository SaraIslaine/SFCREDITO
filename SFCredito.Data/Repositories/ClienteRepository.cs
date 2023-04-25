using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly SFcreditoContext context;

        public ClienteRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
