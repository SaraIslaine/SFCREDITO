namespace SFCredito.Dominio.Entidades
{
    public class ControleProducao
    {
        public int IdSituacaoControleProducao { get; set; }
        public int IdAnaliseProposta { get; set; }
        public string Id { get; set; }
        public decimal? ValorRecebimento { get; set; }
        public string NomeCliente { get; set; }
        public virtual AnaliseProposta AnaliseProposta { get; set; }
        public virtual SituacaoControleProducao SituacaoControleProducao { get; set; }

    }
}