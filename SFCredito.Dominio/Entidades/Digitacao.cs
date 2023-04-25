namespace SFCredito.Dominio.Entidades
{
    public class Digitacao
    {
        public long Id { get; set; }

        public Cliente Cliente { get; set; }

        public long IdCliente { get; set; }

        public DateTime DataDigitacao { get; set; }

        public string Observacao { get; set; }
        public Usuario Usuario { get; set; }
        public long IdUsuario { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool FlagDigitacao { get; set; }

        public virtual ICollection<DocumentoCliente>? DocumentoCliente { get; set; }

        public virtual ICollection<AnaliseProposta>? AnaliseProposta { get; set; }

    }
}
