using CodenationRestaurante.Dominio.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodenationRestaurante.Dados.Map
{
    public class PratoMap : IEntityTypeConfiguration<Prato>
    {
        public void Configure(EntityTypeBuilder<Prato> builder)
        {
            builder.ToTable("Prato");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Descricao)
               .HasColumnType("varchar(500)")
               .IsRequired();

            builder.Property(x => x.Preco)
               .HasColumnType("decimal(18,2)")
               .IsRequired();
        }
    }
}
