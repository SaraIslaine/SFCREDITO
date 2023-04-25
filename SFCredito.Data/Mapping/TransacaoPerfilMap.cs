using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class TransacaoPerfilMap : IEntityTypeConfiguration<TransacaoPerfil>
    {
        public void Configure(EntityTypeBuilder<TransacaoPerfil> builder)
        {
            builder.ToTable("TransacaoPerfil");

            builder.HasIndex(e => e.IdPerfil, "Ref20205");

            builder.HasIndex(e => e.IdTelaTransacao, "Ref21203");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .IsFixedLength();

            builder.Property(e => e.IdPerfil).HasColumnName("idPerfil");

            builder.Property(e => e.IdTelaTransacao).HasColumnName("idTelaTransacao");

            builder.Property(e => e.IdPerfil)
                .HasMaxLength(10)
                .HasColumnName("IdPerfil")
                .IsFixedLength();

            builder.HasOne(d => d.Perfil)
                .WithMany(p => p.TransacaoPerfil)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefPerfil205");

            builder.HasOne(d => d.TelaTransacao)
                .WithMany(p => p.TransacaoPerfil)
                .HasForeignKey(d => d.IdTelaTransacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTelaTransacao203");
        }
    }
}