namespace SFCredito.Dominio.Entidades
{
    public class PerfilUsuario
    {
        public Guid Id { get; set; }
        public Usuario Usuario { get; set; }
        public Guid IdUsuario { get; set; }
        public Perfil Perfil { get; set; }
        public Guid IdPerfil { get; set; }


    }
}
