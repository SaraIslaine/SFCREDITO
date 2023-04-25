using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class SituacaoControleProducaoMap : IEntityTypeConfiguration<SituacaoControleProducao>
    {
        public void Configure(EntityTypeBuilder<SituacaoControleProducao> builder)
        {
            builder.ToTable("SituacaoControleProducao");
            builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

            builder.Property(e => e.Descricao).HasMaxLength(50);
        }
    }
}