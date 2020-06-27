using CodenationRestaurante.Dominio.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dados.Map
{
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agenda");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataInicio)
                .HasColumnType("smalldatetime")
                .IsRequired();

            builder.Property(x => x.DataFim)
               .HasColumnType("smalldatetime")
               .IsRequired();
        }
    }
}
