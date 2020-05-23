using Domain.Base;
using Domain.Entidades;

namespace InfraData.UnityOfWork
{
    public interface IUnityOfWork
    {
        IRepositoryBase<Usuario> UsuarioRepository { get; }
        IRepositoryBase<Categoria> CategoriaRepository { get; }

        void Commit();
    }
}
