using SFCredito.Dominio.Entidades;

namespace SFCredito.Web.Models
{
    public class SituacaoCreditoModel
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<ClienteModel> Cliente { get; set; }
    }
}
