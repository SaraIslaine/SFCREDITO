using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.Property(e => e.Id)
                     .ValueGeneratedOnAdd()
                     .HasColumnName("id");

            builder.Property(e => e.Ativo).HasColumnName("ativo");

            builder.Property(e => e.DataAtualizacao)
                .HasColumnType("date")
                .HasColumnName("dataAtualizacao");

            builder.Property(e => e.DataCadastro)
                .HasColumnType("date")
                .HasColumnName("dataCadastro");

            builder.Property(e => e.Login)
                .HasMaxLength(10)
                .HasColumnName("login");

            builder.Property(e => e.NomeCompleto)
                .HasMaxLength(10)
                .HasColumnName("nomeCompleto");

            builder.Property(e => e.Senha)
                .HasMaxLength(10)
                .HasColumnName("senha");
        }
    }
}