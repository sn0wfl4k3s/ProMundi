using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ViewModels.Conteudo;

namespace WebAPI.ViewModels.Tema
{
    public class TemaViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public IList<ConteudoViewModel> Conteudos { get; set; }
    }
}
