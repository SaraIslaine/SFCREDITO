namespace SFCredito.Web.Models
{
    public class TipoBeneficioModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        
        public virtual ICollection<ClienteModel> Cliente { get; set; }
    }
}
