using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class TelaTransacaoMap : IEntityTypeConfiguration<TelaTransacao>
    {
        public void Configure(EntityTypeBuilder<TelaTransacao> builder)
        {
            builder.ToTable("TelaTransacao");

            builder.HasKey(e => e.Id).HasName("PK40");
            builder.Property(e => e.Id).HasColumnName("id")
                      .IsRequired()
                .ValueGeneratedNever();

            builder.Property(e => e.Action)
                     .HasMaxLength(10)
                     .HasColumnName("action");

            builder.Property(e => e.Controller)
                .HasMaxLength(10)
                .HasColumnName("controller");

            builder.Property(e => e.Descricao)
                .HasMaxLength(10)
                .HasColumnName("descricao");
        }
    }
}
