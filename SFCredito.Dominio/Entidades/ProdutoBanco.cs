namespace SFCredito.Dominio.Entidades
{
    public class ProdutoBanco
    {
        public long Id { get; set; }
        public Produto Produto { get; set; }
        public int IdProduto { get; set; }
        public Banco Banco { get; set; }
        public int IdBanco { get; set; }

        public ICollection<SimulacaoBanco> SimulacaoBanco { get; set; }

    }
}
