using Domain.Entidades;

namespace InfraData.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
