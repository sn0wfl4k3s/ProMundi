namespace Domain.Entidades
{
    public class CategoriaUsuario
    {
        public int CategoriaId { get; set; }
        public int UsuarioId { get; set; }
        public Categoria Categoria { get; set; }
        public Usuario Usuario { get; set; }
    }
}
