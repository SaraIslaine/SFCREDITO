namespace SFCredito.Dominio.Entidades
{
    public class DocumentoCliente
    {
        public long Id { get; set; }
        public long IdDigitacao { get; set; }
        public int? IdPerfil { get; set; }
        public DateTime? DataAutalizacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAnexo { get; set; }
        public string Documento { get; set; }
        public long? IdCliente { get; set; }
        public virtual Digitacao Digitacao { get; set; }
        public virtual CartelaClienteFinanceira CartelaClienteFinanceira { get; set; }

    }
}
