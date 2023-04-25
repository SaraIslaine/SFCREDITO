namespace SFCredito.Dominio.Entidades
{
    public class CartelaClienteFinanceira
    {
        public long Id { get; set; }
        public long? IdCliente { get; set; }
        public DateTime? DataFechamento { get; set; }
        public int IdAnaliseProposta { get; set; }

        public AnaliseProposta AnaliseProposta { get; set; }

    }
}
