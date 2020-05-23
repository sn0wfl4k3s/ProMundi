using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ViewModels.Categoria;

namespace WebAPI.ViewModels.Usuario
{
    public class UsuarioViewModelCadastro
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool SeProfissional { get; set; }

        public IList<CategoriaViewModelCadastro> Categorias { get; set; }
    }
}
