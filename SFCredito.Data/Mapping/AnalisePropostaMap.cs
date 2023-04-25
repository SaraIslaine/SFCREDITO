using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class AnalisePropostaMap : IEntityTypeConfiguration<AnaliseProposta>
    {
        public void Configure(EntityTypeBuilder<AnaliseProposta> builder)
        {
            builder.ToTable("AnaliseProposta");
            builder.HasIndex(e => e.IdDigitacao, "Ref24194");

            builder.HasIndex(e => e.IdSituacaoProposta, "Ref44218");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property(e => e.DataLiberacao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataLiberacao");

            builder.Property(e => e.IdDigitacao).HasColumnName("idDigitacao");

            builder.Property(e => e.IdSituacaoProposta).HasColumnName("idSituacaoProposta");

            builder.Property(e => e.Motivo)
                .HasMaxLength(200)
                .HasColumnName("motivo");

            builder.HasOne(d => d.Digitacao)
                .WithMany(p => p.AnaliseProposta)
                .HasForeignKey(d => d.IdDigitacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefDigitacao194");

            builder.HasOne(d => d.SituacaoProposta)
                .WithMany(p => p.AnaliseProposta)
                .HasForeignKey(d => d.IdSituacaoProposta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefSituacaoProposta218");
        }
    }
}