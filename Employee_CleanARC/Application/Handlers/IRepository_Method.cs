namespace b.Application.Handlers
{
    public interface IRepository_Method<T> where T : class //type : class
    {

        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int EmployeeId); //param nhận vào là id
        Task<T> AddAsync(T entity); // //param nhận vào là 1 entity
        Task UpdateAsync(T entity, int EmployeeId);
        Task DeleteAsync(T entity, int EmployeeId);

    }
}


