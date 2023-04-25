namespace SFCredito.Dominio.Entidades
{
    public class DocumentoAssinatura
    {
        public long Id { get; set; }
        public string AssinaturaCliente { get; set; }
        public string AssinaturaRogo { get; set; }
        public long IdSimulacao { get; set; }

        public virtual Simulacao Simulacao { get; set; }
    }
}
