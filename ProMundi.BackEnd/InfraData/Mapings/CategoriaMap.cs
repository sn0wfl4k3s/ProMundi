using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Mapings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Titulo).HasMaxLength(255).IsRequired();
            
            builder.HasMany(x => x.CategoriaUsuarios).WithOne(x => x.Categoria);
            builder.HasMany(x => x.CategoriaConteudos).WithOne(x => x.Categoria);
        }
    }
}
