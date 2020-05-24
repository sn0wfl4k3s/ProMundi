using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ViewModels.Conteudo;
using WebAPI.ViewModels.Usuario;

namespace WebAPI.ViewModels.Comentario
{
    public class ComentarioViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public int ConteudoId { get; set; }
     
    }
}
