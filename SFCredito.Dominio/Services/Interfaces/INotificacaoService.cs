using SFCredito.Shared.ObjetosAuxiliares;

namespace SFCredito.Dominio.Services.Interfaces
{
    public interface INotificacaoService
    {
        Notificacao Notificacoes(Notificacao notificacao);
        Notificacao MostrarNotificacoes();
    }
}
