namespace SFCredito.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }
        public virtual ICollection<ProdutoBanco> ProdutoBanco { get; set; }
    }
}
