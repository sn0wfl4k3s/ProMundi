using System.Collections.Generic;

namespace Domain.Entidades
{
    public class Tema
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<ConteudoTema> TemaConteudos { get; set; }
    }
}
