using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModels.Tema
{
    public class TemaViewModelCadastro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
