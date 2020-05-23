using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Mapings
{
    public class ConteudoCategoriaMap : IEntityTypeConfiguration<ConteudoCategoria>
    {
        public void Configure(EntityTypeBuilder<ConteudoCategoria> builder)
        {
            builder.HasKey(x => new { x.CategoriaId, x.ConteudoId });

            builder.HasOne(x => x.Categoria)
                .WithMany(x => x.CategoriaConteudos)
                .HasForeignKey(x => x.CategoriaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Conteudo)
                .WithMany(x => x.ConteudoCategorias)
                .HasForeignKey(x => x.ConteudoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
