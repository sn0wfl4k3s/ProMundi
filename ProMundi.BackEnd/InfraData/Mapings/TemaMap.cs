﻿using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Mapings
{
    public class TemaMap : IEntityTypeConfiguration<Tema>
    {
        public void Configure(EntityTypeBuilder<Tema> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Titulo).HasMaxLength(255).IsRequired();
            builder.Property(x => x.DataCriacao).IsRequired();

            builder.HasMany(x => x.TemaConteudos).WithOne(x => x.Tema);
        }
    }
}
