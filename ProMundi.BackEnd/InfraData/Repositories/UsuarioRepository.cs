using Domain.Entidades;

namespace InfraData.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
