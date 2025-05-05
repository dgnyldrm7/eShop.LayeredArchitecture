namespace App.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IQueryable<T>> GetQueryable();
        Task<IEnumerable<T>> GetAllAsync();        
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}