using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(e => e.Id).HasName("PK1");
            builder.Property(e => e.Id).HasColumnName("id")
                      .IsRequired()
                .ValueGeneratedOnAdd();

            builder.HasIndex(e => e.IdSitucaoCredito, "Ref2982");

            builder.HasIndex(e => e.IdTipoBeneficiario, "Ref40118");

            builder.Property(e => e.Conhecido)
                .HasMaxLength(100)
                .HasColumnName("conhecido");

            builder.Property(e => e.Cpf).HasMaxLength(11);

            builder.Property(e => e.DataCadastro)
                .HasColumnType("date")
                .HasColumnName("dataCadastro");

            builder.Property(e => e.DataNascimento)
                .HasColumnType("date")
                .HasColumnName("dataNascimento");

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");

            builder.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasColumnName("endereco");

            builder.Property(e => e.IdSitucaoCredito)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("idSitucaoCredito")
                .IsFixedLength();

            builder.Property(e => e.IdTipoBeneficiario).HasColumnName("idTipoBeneficiario");

            builder.Property(e => e.IdUsuario).HasColumnName("idUsuario");

            builder.Property(e => e.Nome).HasMaxLength(100);

            builder.Property(e => e.NomeTestemunha)
                .HasMaxLength(100)
                .HasColumnName("nomeTestemunha");

            builder.Property(e => e.Obersevacao)
                .HasMaxLength(200)
                .HasColumnName("obersevacao");

            builder.Property(e => e.PontoReferencia)
                .HasMaxLength(100)
                .HasColumnName("pontoReferencia");

            builder.Property(e => e.Rg).HasMaxLength(11);

            builder.HasOne(d => d.IdSitucaoCreditoNavigation)
                .WithMany(p => p.Cliente)
                .HasForeignKey(d => d.IdSitucaoCredito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefSituacaoCredito82");

            builder.HasOne(d => d.IdTipoBeneficiarioNavigation)
                .WithMany(p => p.Cliente)
                .HasForeignKey(d => d.IdTipoBeneficiario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTipoBeneficio118");
        }
    }
}