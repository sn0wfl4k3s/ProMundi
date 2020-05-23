using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Mapings
{
    public class ConteudoTemaMap : IEntityTypeConfiguration<ConteudoTema>
    {
        public void Configure(EntityTypeBuilder<ConteudoTema> builder)
        {
            builder.HasKey(x => new { x.TemaId, x.ConteudoId });

            builder.HasOne(x => x.Tema)
                .WithMany(x => x.TemaConteudos)
                .HasForeignKey(x => x.TemaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Conteudo)
                .WithMany(x => x.ConteudoTemas)
                .HasForeignKey(x => x.ConteudoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
