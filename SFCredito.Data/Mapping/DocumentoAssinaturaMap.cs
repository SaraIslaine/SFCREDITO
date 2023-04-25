using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class DocumentoAssinaturaMap : IEntityTypeConfiguration<DocumentoAssinatura>
    {
        public void Configure(EntityTypeBuilder<DocumentoAssinatura> builder)
        {
            builder.ToTable("DocumentoAssinatura");
            builder.HasIndex(e => e.IdSimulacao, "Ref888");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            builder.HasKey(e => e.Id).HasName("PK30");

            builder.Property(e => e.AssinaturaCliente)
                .HasMaxLength(200)
                .HasColumnName("assinaturaCliente");

            builder.Property(e => e.AssinaturaRogo)
                .HasMaxLength(200)
                .HasColumnName("assinaturaRogo");

            builder.Property(e => e.IdSimulacao).HasColumnName("idSimulacao");

            builder.HasOne(d => d.Simulacao)
                .WithMany(p => p.DocumentoAssinatura)
                .HasForeignKey(d => d.IdSimulacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefSimulacao88");
        }
    }
}