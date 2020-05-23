using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Mapings
{
    public class CategoriaUsuarioMap : IEntityTypeConfiguration<CategoriaUsuario>
    {
        public void Configure(EntityTypeBuilder<CategoriaUsuario> builder)
        {
            builder.HasKey(x => new { x.CategoriaId, x.UsuarioId });

            builder.HasOne(x => x.Categoria)
                .WithMany(x => x.CategoriaUsuarios)
                .HasForeignKey(x => x.CategoriaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.UsuarioCategorias)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}