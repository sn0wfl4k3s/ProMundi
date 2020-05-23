namespace Domain.Entidades
{
    public class CategoriaConteudo
    {
        public int CategoriaId { get; set; }
        public int ConteudoId { get; set; }
        public Categoria Categoria { get; set; }
        public Conteudo Conteudo { get; set; }
    }
}
