using CodenationRestaurante.Dominio.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodenationRestaurante.Dados.Map
{
    public class IngredienteMap : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("Ingrediente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Descricao)
               .HasColumnType("varchar(500)");
        }
    }
}
