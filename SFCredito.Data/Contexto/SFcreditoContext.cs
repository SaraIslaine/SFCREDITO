using Microsoft.EntityFrameworkCore;
using SFCredito.Data.Configuracao;
using SFCredito.Dominio.Entidades;

namespace SFCredito.Data.Contexto
{
    public partial class SFcreditoContext : DbContext
    {
        public SFcreditoContext(DbContextOptions<SFcreditoContext> options)
            : base(options)
        {

        }

        public virtual DbSet<AnaliseProposta> AnaliseProposta { get; set; }
        public virtual DbSet<AniversarianteDia> AniversarianteDia { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<CartelaClienteFinanceira> CartelaClienteFinanceira { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ControleProducao> ControleProducao { get; set; }
        public virtual DbSet<Digitacao> Digitacao { get; set; }
        public virtual DbSet<DocumentoAssinatura> DocumentoAssinatura { get; set; }
        public virtual DbSet<DocumentoCliente> DocumentoCliente { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public virtual DbSet<PreAgendamento> PreAgendamento { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoBanco> ProdutoBanco { get; set; }
        public virtual DbSet<Simulacao> Simulacao { get; set; }
        public virtual DbSet<SimulacaoBanco> SimulacaoBanco { get; set; }
        public virtual DbSet<SituacaoControleProducao> SituacaoControleProducao { get; set; }
        public virtual DbSet<SituacaoCredito> SituacaoCredito { get; set; }
        public virtual DbSet<SituacaoProposta> SituacaoProposta { get; set; }
        public virtual DbSet<TelaTransacao> TelaTransacao { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
        public virtual DbSet<TipoBeneficio> TipoBeneficio { get; set; }
        public virtual DbSet<TransacaoPerfil> TransacaoPerfil { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new TelaTransacaoMap());
            modelBuilder.ApplyConfiguration(new TipoBeneficioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new TransacaoPerfilMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            modelBuilder.ApplyConfiguration(new PreAgendamentoMap());
            modelBuilder.ApplyConfiguration(new SimulacaoMap());
            modelBuilder.ApplyConfiguration(new SimulacaoBancoMap());
            modelBuilder.ApplyConfiguration(new BancoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new DocumentoAssinaturaMap());
            modelBuilder.ApplyConfiguration(new DocumentoClienteMap());
            modelBuilder.ApplyConfiguration(new SimulacaoMap());
            modelBuilder.ApplyConfiguration(new AnalisePropostaMap());
            modelBuilder.ApplyConfiguration(new ControleProducaoMap());
            modelBuilder.ApplyConfiguration(new SituacaoControleProducaoMap());
            modelBuilder.ApplyConfiguration(new CartelaClienteFinanceiraMap());
            modelBuilder.ApplyConfiguration(new SituacaoPropostaMap());
        }
    }
}
