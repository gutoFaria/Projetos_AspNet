using blog.Data;
using blog.Models;
using blog.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace blog.Repository.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        public readonly DbSet<TEntity> DbSet;
        public readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            DbSet = context.Set<TEntity>();
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity> GetPerId(Guid Id)
        {
            TEntity? entity = await DbSet.FindAsync(Id);
            return entity!;
        }


        public async Task Remove(Guid id)
        {
            var entityRemove = await GetPerId(id);
            DbSet.Remove(entityRemove);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}