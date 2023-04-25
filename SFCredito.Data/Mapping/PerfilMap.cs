using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("Perfil");

            builder.HasKey(e => e.Id).HasName("PK20");
            builder.Property(e => e.Id).HasColumnName("id")
                      .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Nome).HasColumnName("nome");
        }
    }
}
