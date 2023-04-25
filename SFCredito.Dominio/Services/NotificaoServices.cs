using SFCredito.Dominio.Services.Interfaces;
using SFCredito.Shared.ObjetosAuxiliares;


namespace SFCredito.Dominio.Services
{
    public class NotificaoServices : Notificacao, INotificacaoService
    {
        public Notificacao MostrarNotificacoes()
        {
            return this;
        }

        public Notificacao Notificacoes(Notificacao notificacao)
        {

            this.Descricao = notificacao.Descricao;
            this.Acao = notificacao.Acao;
            this.Erro = notificacao.Erro;
            this.TipoMensagem = notificacao.TipoMensagem;
            this.Titulo = notificacao.Titulo;
            return MostrarNotificacoes();

        }
    }
}
