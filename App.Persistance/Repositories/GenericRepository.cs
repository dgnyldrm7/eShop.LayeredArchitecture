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
        
        public async Task AddAsync(T entity)
        {
            _dbSet.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await _dbSet.FindAsync(Id);

            if (entity != null)
            {
                _dbSet.Remove(entity);

                await _context.SaveChangesAsync();
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

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}