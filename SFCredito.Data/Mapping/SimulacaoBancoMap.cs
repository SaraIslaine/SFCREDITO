using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class SimulacaoBancoMap : IEntityTypeConfiguration<SimulacaoBanco>
    {
        public void Configure(EntityTypeBuilder<SimulacaoBanco> builder)
        {
            builder.ToTable("SimulacaoBanco");
            builder.HasIndex(e => e.IdProdutoBanco, "Ref39207");

            builder.HasIndex(e => e.IdSimulacao, "Ref8182");

            builder.HasKey(e => e.Id).HasName("PK43");
            builder.Property(e => e.Id).HasColumnName("id")
                      .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(e => e.IdProdutoBanco).HasColumnName("idProdutoBanco");

            builder.Property(e => e.IdSimulacao).HasColumnName("idSimulacao");

            builder.Property(e => e.ValorOperacao)
                .HasPrecision(10)
                .HasColumnName("valorOperacao");

            builder.Property(e => e.ValorParcela).HasPrecision(10);

            builder.HasOne(d => d.ProdutoBanco)
                .WithMany(p => p.SimulacaoBanco)
                .HasForeignKey(d => d.IdProdutoBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefProduto_Banco207");

            builder.HasOne(d => d.Simulacao)
                .WithMany(p => p.SimulacaoBanco)
                .HasForeignKey(d => d.IdSimulacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefSimulacao182");
        }
    }
}