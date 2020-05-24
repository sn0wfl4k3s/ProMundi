using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        T GetById(int id);
        Task AddAsync(T model);
        Task Update(T model);
        Task Delete(int id);
    }
}
