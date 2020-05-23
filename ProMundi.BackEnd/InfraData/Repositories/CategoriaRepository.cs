using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>
    {
        public  CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
