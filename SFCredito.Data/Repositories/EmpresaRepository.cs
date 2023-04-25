using SFCredito.Data.Contexto;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;

namespace SFCredito.Data.Repositories
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        private readonly SFcreditoContext context;

        public EmpresaRepository(SFcreditoContext _context)
         : base(_context)
        {
            context = _context;
        }
    }
}
