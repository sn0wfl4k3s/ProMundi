using System.Collections.Generic;

namespace Domain.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public List<CategoriaUsuario> CategoriaUsuarios { get; set; }
        public List<ConteudoCategoria> CategoriaConteudos { get; set; }
    }
}
