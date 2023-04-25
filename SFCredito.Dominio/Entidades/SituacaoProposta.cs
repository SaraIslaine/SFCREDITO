namespace SFCredito.Dominio.Entidades
{
    public class SituacaoProposta
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<AnaliseProposta> AnaliseProposta { get; set; }
    }
}
