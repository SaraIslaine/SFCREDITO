namespace SFCredito.Dominio.Entidades
{
    public class SimulacaoBanco
    {
        public long Id { get; set; }
        public long IdProdutoBanco { get; set; }
        public bool? FlagSimulado { get; set; }
        public decimal? ValorOperacao { get; set; }
        public int? QuantidadeParcela { get; set; }
        public decimal? ValorParcela { get; set; }
        public long IdSimulacao { get; set; }
        public virtual ProdutoBanco ProdutoBanco { get; set; }
        public virtual Simulacao Simulacao { get; set; }
    }
}
