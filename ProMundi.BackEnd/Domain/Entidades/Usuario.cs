using System;
using System.Collections.Generic;

namespace Domain.Entidades
{
    public class Usuario
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

        public List<Conteudo> Conteudos { get; set; }

        public List<Comentario> Comentarios { get; set; }

        public List<CategoriaUsuario> UsuarioCategorias { get; set; }
    }
}
