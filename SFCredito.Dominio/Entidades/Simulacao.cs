namespace SFCredito.Dominio.Entidades
{
    public class Simulacao
    {
        public Simulacao()
        {
            DocumentoAssinatura = new HashSet<DocumentoAssinatura>();
            SimulacaoBanco = new HashSet<SimulacaoBanco>();
        }

        public long Id { get; set; }
        public string Obervacao { get; set; }
        public long? IdCliente { get; set; }
        public long? NumeroBeneficio { get; set; }
        public DateTime? DataBeneficio { get; set; }
        public bool? Bloqueado { get; set; }
        public bool? RepresentanteLegal { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DocumentoAssinatura> DocumentoAssinatura { get; set; }
        public virtual ICollection<SimulacaoBanco> SimulacaoBanco { get; set; }

    }
}
