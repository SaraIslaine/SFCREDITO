using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class CartelaClienteFinanceiraMap : IEntityTypeConfiguration<CartelaClienteFinanceira>
    {
        public void Configure(EntityTypeBuilder<CartelaClienteFinanceira> builder)
        {
            builder.ToTable("CartelaClienteFinanceira");
            builder.HasIndex(e => e.IdAnaliseProposta, "Ref45222");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property(e => e.DataFechamento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataFechamento");

            builder.Property(e => e.IdAnaliseProposta).HasColumnName("idAnaliseProposta");

            builder.HasOne(d => d.AnaliseProposta)
                .WithMany(p => p.CartelaClienteFinanceira)
                .HasForeignKey(d => d.IdAnaliseProposta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefAnaliseProposta222");

        }
    }
}