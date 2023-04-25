namespace SFCredito.Dominio.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
            Empresa = new HashSet<Empresa>();
            PerfilUsuario = new HashSet<PerfilUsuario>();
        }

        public long Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool? Ativo { get; set; }
        public virtual ICollection<Empresa> Empresa { get; set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuario { get; set; }

    }
}
