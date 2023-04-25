using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SFCredito.Web.Models
{
    public class UsuarioModel
    {

        public long Id { get; set; } 
        [Required(ErrorMessage = "Nome completo Obrigatório")]
        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [DisplayName("Data Atualização")]
        public DateTime? DataAtualizacao { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
        public long IdPerfil { get; set; }
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Login Obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha Obrigatória")]
        public string Senha { get; set; }

        //public UsuarioNovaSenhaModel UsuarioNovaSenhaModel { get; set; }

    }
}
