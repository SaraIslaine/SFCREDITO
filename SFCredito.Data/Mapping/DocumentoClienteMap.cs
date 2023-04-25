using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SFCredito.Data.Configuracao
{
    using Dominio.Entidades;

    public class DocumentoClienteMap : IEntityTypeConfiguration<DocumentoCliente>
    {
        public void Configure(EntityTypeBuilder<DocumentoCliente> builder)
        {
            builder.ToTable("DocumentoCliente");

            builder.HasKey(e => e.Id).HasName("DocumentoCliente_pkey");
            builder.Property(e => e.Id).HasColumnName("id")
                      .IsRequired()
                .ValueGeneratedOnAdd();

            builder.HasIndex(e => e.IdDigitacao, "Ref24188");

            builder.Property(e => e.DataAnexo)
                .HasColumnType("date")
                .HasColumnName("dataAnexo");

            builder.Property(e => e.DataAutalizacao)
                .HasColumnType("date")
                .HasColumnName("dataAutalizacao");

            builder.Property(e => e.DataCadastro)
                .HasColumnType("date")
                .HasColumnName("dataCadastro");

            builder.Property(e => e.Documento)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.IdCliente).HasColumnName("idCliente");

            builder.Property(e => e.IdDigitacao).HasColumnName("idDigitacao");

            builder.Property(e => e.IdPerfil).HasColumnName("idPerfil");

            builder.HasOne(d => d.Digitacao)
                .WithMany()
                .HasForeignKey(d => d.IdDigitacao)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}