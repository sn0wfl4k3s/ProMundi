using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Mapings
{
    public class ConteudoMap : IEntityTypeConfiguration<Conteudo>
    {
        public void Configure(EntityTypeBuilder<Conteudo> builder)
        {
            builder.HasMany(x => x.ConteudoCategorias).WithOne(x => x.Conteudo);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(x => x.DataCriacao).IsRequired();

            builder.HasOne(x => x.Usuario).WithMany(x => x.Conteudos);
            builder.HasMany(x => x.Comentarios).WithOne(x => x.Conteudo);

            builder.HasMany(x => x.ConteudoTemas).WithOne(x => x.Conteudo);
            builder.HasMany(x => x.ConteudoCategorias).WithOne(x => x.Conteudo);
        }
    }
}
