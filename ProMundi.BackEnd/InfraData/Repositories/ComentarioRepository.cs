using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Repositories
{
    public class ComentarioRepository : RepositoryBase<Comentario>
    {
        public ComentarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }

}
