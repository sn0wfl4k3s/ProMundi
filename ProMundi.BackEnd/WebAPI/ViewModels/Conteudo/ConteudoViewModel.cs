using System;
using System.Collections.Generic;
using WebAPI.ViewModels.Categoria;
using WebAPI.ViewModels.Comentario;
using WebAPI.ViewModels.Tema;
using WebAPI.ViewModels.Usuario;

namespace WebAPI.ViewModels.Conteudo
{
    public class ConteudoViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Nota { get; set; }
        public string VideoPath { get; set; }
        public string PodcastPath { get; set; }
        public string UrlImgPost { get; set; }
        public bool Favorito { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEdicao { get; set; }

        public int UsuarioId { get; set; }
        public UsuarioViewModel Usuario { get; set; }

        public IList<CategoriaViewModel> Categorias { get; set; }

        public IList<TemaViewModel> Temas { get; set; }
        public IList<ComentarioViewModel> Comentarios { get; set; }
    }
}
