using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class BancoMap : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.ToTable("Banco");
            builder.Property(e => e.Id)
                      .ValueGeneratedNever()
                      .HasColumnName("id");

            builder.Property(e => e.DataCadastro)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataCadastro");

            builder.Property(e => e.Descriicao)
                .HasMaxLength(100)
                .HasColumnName("descriicao");
        }
    }
}