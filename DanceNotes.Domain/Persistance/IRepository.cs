using System.Linq.Expressions;

namespace DanceNotes.Domain.Persistance;

public interface IRepository<TEntity> where TEntity : class
{
    public Task<TEntity> GetEntityAsync<TProperty>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TProperty>> include);
    public Task<IEnumerable<TEntity>> GetAllAsync();
    public Task InsertAsync(IEnumerable<TEntity> entities);
    public void RemoveAll();
}
