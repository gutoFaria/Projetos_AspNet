using blog.Models;

namespace blog.Repository.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity: Entity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetPerId(Guid Id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task Remove(Guid id);
    }
}