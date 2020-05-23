using System;
using System.Collections.Generic;
using WebAPI.ViewModels.Categoria;
using WebAPI.ViewModels.Comentario;
using WebAPI.ViewModels.Conteudo;

namespace WebAPI.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UrlFoto { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Bio { get; set; }
        public string Senha { get; set; }
        public bool SeProfissional { get; set; }

        public List<ConteudoViewModel> Conteudos { get; set; }

        public List<ComentarioViewModel> Comentarios { get; set; }

        public IList<CategoriaViewModel> Categorias { get; set; }
    }
}
