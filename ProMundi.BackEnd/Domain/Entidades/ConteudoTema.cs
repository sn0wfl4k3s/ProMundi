namespace Domain.Entidades
{
    public class ConteudoTema
    {
        public int ConteudoId { get; set; }
        public int TemaId { get; set; }
        public Tema Tema { get; set; }
        public Conteudo Conteudo { get; set; }
    }
}
