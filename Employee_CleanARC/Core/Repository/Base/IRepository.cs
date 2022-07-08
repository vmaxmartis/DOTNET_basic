namespace a.Core.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> UpdateAsync(int Id);
        Task<T> GetByIdAsync(int Id);
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(int Id);

    }
}

