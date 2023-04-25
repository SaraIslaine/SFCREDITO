using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("Telefone");
            builder.HasIndex(e => e.IdCliente, "Ref12");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Numero).HasMaxLength(10);

            builder.HasOne(d => d.Cliente)
                .WithMany(p => p.Telefone)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefCliente2");
        }
    }
}