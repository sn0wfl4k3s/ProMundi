using Domain.Entidades;

namespace InfraData.Repositories
{
    public class ConteudoRepository : RepositoryBase<Conteudo>
    {
        public ConteudoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
