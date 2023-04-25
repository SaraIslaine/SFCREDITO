namespace SFCredito.Dominio.Entidades
{
    public class Telefone
    {
        public long Id { get; set; }

        public int Numero { get; set; }

        public long IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
