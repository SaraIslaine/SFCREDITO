namespace SFCredito.Dominio.Entidades
{
    public class AniversarianteDia
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }
        public Guid IdCliente { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Nome { get; set; }

        public long Cpf { get; set; }

    }
}
