namespace SFCredito.Shared.ObjetosAuxiliares
{
    public class Notificacao
    {
        public Notificacao()
        {
            this.erroMensagenAuxliars = new List<Notificacao>();
        }

        public string Descricao { get; set; }
        public bool Erro { get; set; }
        public bool Acao { get; set; }
        public string TipoMensagem { get; set; }
        public string Titulo { get; set; }
        public List<Notificacao> erroMensagenAuxliars { get; set; }
    }
}
