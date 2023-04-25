namespace SFCredito.Dominio.Entidades
{
    public class SituacaoCredito
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }


    }
}
