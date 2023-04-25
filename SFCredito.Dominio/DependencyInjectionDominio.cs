using Microsoft.Extensions.DependencyInjection;
using SFCredito.Dominio.Services;
using SFCredito.Dominio.Services.Interfaces;

namespace SFCredito.Dominio
{
    public static class DependencyInjectionDominio
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IDocumentoClienteServices, DocumentoClienteServices>();
            services.AddScoped<IDigitacaoServices, DigitacaoServices>();
            services.AddScoped<IDocumentoAssinaturaServices, DocumentoAssinaturaServices>();
            services.AddScoped<IPerfilServices, PerfilServices>();
            services.AddScoped<IBancoServices, BancoServices>();
            services.AddScoped<IAnalisePropostaServices, AnalisePropostaServices>();
            services.AddScoped<IControleProducaoServices, ControleProducaoServices>();
            services.AddScoped<IEmpresaServices, EmpresaServices>();
            services.AddScoped<IPerfilUsuarioServices, PerfilUsuarioServices>();
            services.AddScoped<IPreAgendamentoServices, PreAgendamentoServices>();
            services.AddScoped<IPerfilServices, PerfilServices>();
            services.AddScoped<IProdutoServices, ProdutoServices>();
            services.AddScoped<ISimulacaoServices, SimulacaoServices>();
            services.AddScoped<ISituacaoControleProducaoServices, SituacaoControleProducaoServices>();
            services.AddScoped<ISimulacaoBancoServices, SimulacaoBancoServices>();
            services.AddScoped<ISituacaoCreditoServices, SituacaoCreditoServices>();
            services.AddScoped<ISituacaoPropostaServices, SituacaoPropostaServices>();
            services.AddScoped<ITelaTransacaoServices, TelaTransacaoServices>();
            services.AddScoped<ITelefoneServices, TelefoneServices>();
            services.AddScoped<ITipoBeneficioServices, TipoBeneficioServices>();
            services.AddScoped<ITransacaoPerfilServices, TransacaoPerfilServices>();
            services.AddScoped<IUsuarioServices, UsuarioServices>();
            services.AddScoped<ICartelaClienteFinanceiraServices, CartelaClienteFinanceiraServices>();
            services.AddScoped<IClienteServices, ClienteServices>();
            services.AddScoped<IProdutoBancoServices, ProdutoBancoServices>();
            services.AddScoped<INotificacaoService, NotificaoServices>();
        }
    }
}