using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class ControleProducaoMap : IEntityTypeConfiguration<ControleProducao>
    {
        public void Configure(EntityTypeBuilder<ControleProducao> builder)
        {
            builder.ToTable("ControleProducao");
            builder.HasNoKey();

            builder.HasIndex(e => e.IdAnaliseProposta, "Ref45201");

            builder.HasIndex(e => e.IdSituacaoControleProducao, "Ref46199");

            builder.Property(e => e.Id)
                .HasMaxLength(10)
                .HasColumnName("id")
                .IsFixedLength();

            builder.Property(e => e.IdSituacaoControleProducao).HasColumnName("idSituacaoControleProducao");

            builder.Property(e => e.NomeCliente)
                .HasMaxLength(10)
                .IsFixedLength();

            builder.Property(e => e.ValorRecebimento)
                .HasPrecision(10)
                .HasColumnName("valorRecebimento");

            builder.HasOne(d => d.AnaliseProposta)
                .WithMany()
                .HasForeignKey(d => d.IdAnaliseProposta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefAnaliseProposta201");

            builder.HasOne(d => d.SituacaoControleProducao)
                .WithMany()
                .HasForeignKey(d => d.IdSituacaoControleProducao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefSituacaoControleProducao199");
        }
    }
}