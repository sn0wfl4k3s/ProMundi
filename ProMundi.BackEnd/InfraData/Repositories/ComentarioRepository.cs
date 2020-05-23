using Domain.Entidades;

namespace InfraData.Repositories
{
    public class ComentarioRepository : RepositoryBase<Comentario>
    {
        public ComentarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }

}
