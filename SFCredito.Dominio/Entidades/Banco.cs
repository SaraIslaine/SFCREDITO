namespace SFCredito.Dominio.Entidades
{
    public class Banco
    {
        public Banco()
        {
            ProdutoBanco = new HashSet<ProdutoBanco>();
        }

        public int Id { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Descriicao { get; set; }

        public virtual ICollection<ProdutoBanco> ProdutoBanco { get; set; }
    }
}
