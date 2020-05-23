using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Repositories
{
    public class TemaRepository : RepositoryBase<Tema>
    {
        public TemaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

