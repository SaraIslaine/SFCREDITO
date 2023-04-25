namespace SFCredito.Dominio.Entidades
{
    public class TelaTransacao
    {
        public TelaTransacao()
        {
            TransacaoPerfil = new HashSet<TransacaoPerfil>();
        }

        public long Id { get; set; }

        public string Descricao { get; set; }

        public string Action { get; set; }

        public string Controller { get; set; }

        public ICollection<TransacaoPerfil> TransacaoPerfil { get; set; }

    }
}

