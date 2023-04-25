using System.ComponentModel.DataAnnotations;

namespace SFCredito.Web.Models
{
    public class UsuarioNovaSenhaModel
    {
       

        [Required(ErrorMessage = "Senha Obrigatória")]

        public string NovaSenha { get; set; }    
        
        [Required(ErrorMessage = "Senha Obrigatória")]

        public string Senha { get; set; }

        [Required(ErrorMessage = "Senha Obrigatória")]

        [Compare("NovaSenha")]
        public string ConfirmaSenha { get; set; }

        public  UsuarioModel Usuario { get; set; }

    }
}
