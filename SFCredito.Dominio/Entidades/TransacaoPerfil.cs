namespace SFCredito.Dominio.Entidades
{
    public class TransacaoPerfil
    {
        public long Id { get; set; }
        public long IdTelaTransacao { get; set; }
        public long IdPerfil { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual TelaTransacao TelaTransacao { get; set; }
    }
}
