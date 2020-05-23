using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Mapings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Senha).HasMaxLength(255).IsRequired();
            builder.Property(x => x.SeProfissional).IsRequired();

            builder.HasMany(x => x.UsuarioCategorias).WithOne(x => x.Usuario);

            builder.HasMany(x => x.Conteudos).WithOne(x => x.Usuario);

        }

    }
}
