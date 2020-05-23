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
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        public UsuarioViewModel Usuario { get; set; }

        public IList<CategoriaViewModel> Categorias { get; set; }

        public IList<TemaViewModel> Temas { get; set; }
    }
}
