using Domain.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfraData.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async Task AddAsync(T model)
        {
            await _context.Set<T>().AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            _context.Set<T>().Remove(GetById(id));
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync();
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual Task Update(T model)
        {
            _context.Set<T>().Update(model);
            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}