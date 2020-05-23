using Domain.Entidades;
using InfraData.Mapings;
using Microsoft.EntityFrameworkCore;

namespace InfraData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ConteudoCategoria> CategoriaConteudos { get; set; }
        public DbSet<CategoriaUsuario> CategoriaUsuarios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<ConteudoTema> ConteudoTemas { get; set; }
        public DbSet<Tema> Temas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ConteudoCategoriaMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new CategoriaUsuarioMap());
            modelBuilder.ApplyConfiguration(new ComentarioMap());
            modelBuilder.ApplyConfiguration(new ConteudoMap());
            modelBuilder.ApplyConfiguration(new ConteudoTemaMap());
        }
    }
}
