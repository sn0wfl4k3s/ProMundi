using System;
using System.Collections.Generic;

namespace Domain.Entidades
{
    public class Conteudo
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
        public Usuario Usuario { get; set; }

        public List<ConteudoCategoria> ConteudoCategorias { get; set; }

        public List<ConteudoTema> ConteudoTemas { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}
