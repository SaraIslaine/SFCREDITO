using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class TipoBeneficioMap : IEntityTypeConfiguration<TipoBeneficio>
    {
        public void Configure(EntityTypeBuilder<TipoBeneficio> builder)
        {
            builder.ToTable("TipoBeneficio");

            builder.HasKey(e => e.Id).HasName("PK40");
            builder.Property(e => e.Id).HasColumnName("id")
                      .IsRequired()
                .ValueGeneratedNever();

            builder.Property(e => e.Descricao).HasMaxLength(10);
        }
    }
}
