using App.Core.Interfaces;
using App.Persistance.DbContext;
using Microsoft.EntityFrameworkCore;

namespace App.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;

            _dbSet = context.Set<T>();
        }
        
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(int Id)
        {
            var entity =  _dbSet.Find(Id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Task<IQueryable<T>> GetQueryable()
        {
            return Task.FromResult(_dbSet.AsQueryable());
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}