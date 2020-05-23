using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Repositories
{
    public class ConteudoRepository : RepositoryBase<Conteudo>
    {
        public ConteudoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
