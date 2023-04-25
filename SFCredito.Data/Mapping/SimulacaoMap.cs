using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class SimulacaoMap : IEntityTypeConfiguration<Simulacao>
    {
        public void Configure(EntityTypeBuilder<Simulacao> builder)
        {
            builder.ToTable("Simulacao");
            builder.HasIndex(e => e.IdCliente, "Ref165");

            builder.HasKey(e => e.Id).HasName("PK8");
            builder.Property(e => e.Id).HasColumnName("id")
                      .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Bloqueado).HasColumnName("bloqueado");

            builder.Property(e => e.DataBeneficio)
                .HasColumnType("date")
                .HasColumnName("dataBeneficio");

            builder.Property(e => e.IdCliente).HasColumnName("idCliente");

            builder.Property(e => e.NumeroBeneficio).HasColumnName("numeroBeneficio");

            builder.Property(e => e.Obervacao)
                .HasMaxLength(100)
                .HasColumnName("obervacao");

            builder.Property(e => e.RepresentanteLegal).HasColumnName("representanteLegal");

            builder.HasOne(d => d.Cliente)
                .WithMany(p => p.Simulacao)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("RefCliente65");
        }
    }
}