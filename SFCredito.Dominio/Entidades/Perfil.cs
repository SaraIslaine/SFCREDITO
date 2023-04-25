namespace SFCredito.Dominio.Entidades
{
    public class Perfil
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public ICollection<PerfilUsuario> PerfilUsuario { get; set; }

        public ICollection<TransacaoPerfil> TransacaoPerfil { get; set; }
    }
}
