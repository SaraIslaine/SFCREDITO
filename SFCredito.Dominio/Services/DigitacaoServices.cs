
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class DigitacaoServices : IDigitacaoServices
    {
        private readonly IDigitacaoRepository _digitacaoRepository;
            
        public DigitacaoServices(IDigitacaoRepository digitacaoRepository)
        {
            this._digitacaoRepository = digitacaoRepository;
        }

       
    }
}