using Domain.Entidades;

namespace InfraData.Repositories
{
    public class TemaRepository : RepositoryBase<Tema>
    {
        public TemaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

