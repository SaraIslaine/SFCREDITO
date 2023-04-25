namespace SFCredito.Dominio.Entidades
{
    public class AnaliseProposta
    {
        public AnaliseProposta()
        {
            CartelaClienteFinanceira = new HashSet<CartelaClienteFinanceira>();
        }
        public int Id { get; set; }
        public int IdSituacaoProposta { get; set; }
        public DateTime? DataLiberacao { get; set; }
        public string Motivo { get; set; }
        public long IdDigitacao { get; set; }
        public virtual Digitacao Digitacao { get; set; }
        public virtual SituacaoProposta SituacaoProposta { get; set; }
        public virtual ICollection<CartelaClienteFinanceira> CartelaClienteFinanceira { get; set; }
    }
}
