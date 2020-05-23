using Domain.Base;
using Domain.Entidades;
using InfraData.Repositories;
using System;

namespace InfraData.UnityOfWork
{
    public class UnitOfWork : IUnityOfWork, IDisposable
    {
        private ApplicationDbContext _context = null;
        private RepositoryBase<Usuario> usuariRepository = null;
        private RepositoryBase<Categoria> employeeRepository = null;

        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public IRepositoryBase<Usuario> UsuariRepository
        {
            get
            {
                if (usuariRepository == null)
                {
                    usuariRepository = new RepositoryBase<Usuario>(_context);
                }
                return usuariRepository;
            }
        }
        public IRepositoryBase<Categoria> EmployeeRepository
        {
            get
            {
                if (employeeRepository == null)
                {
                    employeeRepository = new RepositoryBase<Categoria>(_context);
                }
                return employeeRepository;
            }
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}