using a.Core.Repository.Base;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace c.Infrastructure.Repository_Method
{
    public class RepositoryMethodBase : IRepository<T> where T : Object

    {
        protected readonly VContext _vContext;
        public RepositoryMethodBase(VContext vContext)
        {
            _vContext = vContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _vContext.Set<T>().AddAsync(entity);
            await _vContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _vContext.Set<T>().Remove(entity);
            await _vContext.SaveChangesAsync();
        }

        public Task<T> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _vContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await _vContext.Set<T>().FindAsync(Id);
        }

        public Task<T> UpdateAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

// 
