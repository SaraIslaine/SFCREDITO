using SFCredito.Dominio.Entidades;

namespace SFCredito.Web.Models
{
    public class ClienteModel
    {
        public ClienteModel()
        {
            Digitacao = new HashSet<Digitacao>();
            PreAgendamento = new HashSet<PreAgendamento>();
            Simulacao = new HashSet<Simulacao>();
            Telefone = new HashSet<Telefone>();
        }

        public long Id { get; set; }
        public int IdTipoBeneficiario { get; set; }
        public string IdSitucaoCredito { get; set; }
        public string NomeTestemunha { get; set; }
        public long? IdUsuario { get; set; }
        public string Obersevacao { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Conhecido { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Rg { get; set; }
        public string PontoReferencia { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public virtual SituacaoCredito IdSitucaoCreditoNavigation { get; set; }
        public virtual TipoBeneficio IdTipoBeneficiarioNavigation { get; set; }
        public virtual ICollection<Digitacao> Digitacao { get; set; }
        public virtual ICollection<PreAgendamento> PreAgendamento { get; set; }
        public virtual ICollection<Simulacao> Simulacao { get; set; }
        public virtual ICollection<Telefone> Telefone { get; set; }
    }
}
