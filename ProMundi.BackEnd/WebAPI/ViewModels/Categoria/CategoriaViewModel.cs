using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ViewModels.Conteudo;
using WebAPI.ViewModels.Usuario;

namespace WebAPI.ViewModels.Categoria
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public IList<UsuarioViewModel> Usuarios { get; set; }
        public IList<ConteudoViewModel> Conteudos { get; set; }
    }
}
