using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Mapings
{
    public class ComentarioMap : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(255).IsRequired();

            builder.HasOne(x => x.Usuario).WithMany(x => x.Comentarios);
            builder.HasOne(x => x.Conteudo).WithMany(x => x.Comentarios);

        }
    }
}
