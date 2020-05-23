using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
