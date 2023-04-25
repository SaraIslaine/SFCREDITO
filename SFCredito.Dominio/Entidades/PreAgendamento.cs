namespace SFCredito.Dominio.Entidades
{
    public class PreAgendamento
    {
        public int Id { get; set; }
        public long IdCliente { get; set; }
        public string DataAgendamento { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public virtual Cliente Cliente { get; set; }

    }
}
