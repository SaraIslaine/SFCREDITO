using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class SituacaoPropostaMap : IEntityTypeConfiguration<SituacaoProposta>
    {
        public void Configure(EntityTypeBuilder<SituacaoProposta> builder)
        {
            builder.ToTable("SituacaoProposta");
            builder.Property(e => e.Id)
                   .ValueGeneratedNever()
                   .HasColumnName("id");

            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
        }
    }
}