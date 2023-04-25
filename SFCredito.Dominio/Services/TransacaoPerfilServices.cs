using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio.Services
{
    public class TransacaoPerfilServices : ITransacaoPerfilServices
    {
        private readonly ITransacaoPerfilRepository _transacaoperfilRepository;
        private readonly INotificacaoService _notificacaoService;
        public TransacaoPerfilServices(ITransacaoPerfilRepository TransacaoPerfilRepository, INotificacaoService notificacaoService)
        {
            this._transacaoperfilRepository = TransacaoPerfilRepository;
            _notificacaoService = notificacaoService;
        }


    }
}