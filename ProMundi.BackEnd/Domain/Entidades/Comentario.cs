namespace Domain.Entidades
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }


        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int ConteudoId { get; set; }
        public Conteudo Conteudo { get; set; }

    }
}