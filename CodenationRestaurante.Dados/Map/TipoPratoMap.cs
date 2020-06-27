using CodenationRestaurante.Dominio.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dados.Map
{
    public class TipoPratoMap : IEntityTypeConfiguration<TipoPrato>
    {
        public void Configure(EntityTypeBuilder<TipoPrato> builder)
        {
            builder.ToTable("TipoPrato");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.HasMany<Prato>(p => p.Pratos)
                .WithOne(t => t.TipoPrato)
                .HasForeignKey(t => t.IdTipoPrato);
        }
    }
}
