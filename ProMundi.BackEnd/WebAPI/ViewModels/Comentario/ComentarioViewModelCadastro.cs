using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ViewModels.Conteudo;
using WebAPI.ViewModels.Usuario;

namespace WebAPI.ViewModels.Comentario
{
    public class ComentarioViewModelCadastro
    {
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioViewModel Usuario { get; set; }

        public int ConteudoId { get; set; }
        public ConteudoViewModel Conteudo { get; set; }
    }
}
