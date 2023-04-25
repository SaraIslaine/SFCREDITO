using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class TelefoneRepository : BaseRepository<Telefone>, ITelefoneRepository
    {
        private readonly SFcreditoContext context;

        public TelefoneRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
