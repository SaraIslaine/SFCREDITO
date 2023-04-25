using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class PreAgendamentoMap : IEntityTypeConfiguration<PreAgendamento>
    {
        public void Configure(EntityTypeBuilder<PreAgendamento> builder)
        {
            builder.ToTable("PreAgendamento");
            builder.HasIndex(e => e.IdCliente, "Ref1223");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property(e => e.Cpf)
                .HasMaxLength(10)
                .IsFixedLength();

            builder.Property(e => e.DataAgendamento)
                .HasMaxLength(10)
                .IsFixedLength();

            builder.Property(e => e.IdCliente).HasColumnName("idCliente");

            builder.Property(e => e.Nome)
                .HasMaxLength(10)
                .IsFixedLength();

            builder.HasOne(d => d.Cliente)
                .WithMany(p => p.PreAgendamento)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefCliente223");
        }
    }
}