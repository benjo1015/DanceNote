using DanceNotes.Domain.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DanceNotes.Maui.Services.Persistance;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _entities;


    public Repository(DbContext dbContext)
    {
        _entities = dbContext.Set<TEntity>();
    }

    public async Task<TEntity> GetEntityAsync<TProperty>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TProperty>> include)
    {
        return await _entities.Include(include).FirstOrDefaultAsync(filter, new CancellationToken());
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _entities.ToListAsync();
    }

    public async Task InsertAsync(IEnumerable<TEntity> entities)
    {
        await _entities.AddRangeAsync(entities);
    }

    public void RemoveAll()
    {
        _entities.RemoveRange(_entities);
    }
}

