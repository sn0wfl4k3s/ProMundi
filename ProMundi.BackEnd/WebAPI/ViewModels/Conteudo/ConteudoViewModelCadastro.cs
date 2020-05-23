using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ViewModels.Categoria;
using WebAPI.ViewModels.Tema;
using WebAPI.ViewModels.Usuario;

namespace WebAPI.ViewModels.Conteudo
{
    public class ConteudoViewModelCadastro
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        public UsuarioViewModel Usuario { get; set; }

        public IList<CategoriaViewModelCadastro> Categorias { get; set; }

        public IList<TemaViewModelCadastro> Temas { get; set; }
    }
}
