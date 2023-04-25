using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SFCredito.Web.Models
{
    public class EmpresaModel
    {
        public long Id { get; set; }
        [DisplayName("Digite o cep ")]
        public string Cep { get; set; }
        [DisplayName("Digite o Numero da casa ")]
        public int? Numero { get; set; }
        [DisplayName(" Qual seu endereço ")]
        public string Endereco { get; set; }
        [DisplayName("Digite seu Bairro ")]
        public string Bairro { get; set; }
        public long IdUsuario { get; set; }
        public string NomeFantasia { get; set; }
        [DisplayName("Digite o Email")]
        public string Email { get; set; }
        [DisplayName("Digite o seu Número")]
        public string Celular { get; set; }
        [DisplayName("Digite o Cnpj")]
        public string Cnpj { get; set; }
        public string RazacaoSocial { get; set; }
       
    }
}
