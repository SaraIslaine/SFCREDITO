namespace SFCredito.Dominio.Entidades
{
    public class TipoBeneficio
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

    }
}
