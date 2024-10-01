using Infrastructure.Context;
using Infrastructure.Interfaces;
using Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;
public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext Db;
    protected readonly DbSet<TEntity> DbSet;

    public BaseRepository(AppDbContext context)
    {
        Db = context;
        DbSet = Db.Set<TEntity>();
    }

    public virtual void Add(TEntity obj)
    {
        Db.Add(obj);
        Db.SaveChanges();
    }

    public virtual void Update(TEntity obj)
    {
        Db.Update(obj);
        Db.SaveChanges();
    }

    public virtual void Remove(TEntity obj)
    {
        Db.Remove(obj);
        Db.SaveChanges();
    }

    public IQueryable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> expression, params string[] includes)
    {
        IQueryable<TEntity> query = DbSet;

        if (includes != null)
        {
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }

        return query.Where(expression);
    }

    public TEntity GetElementByExpression(Expression<Func<TEntity, bool>> expression, params string[] includes)
    {
        return DbSet.Includes(includes).AsNoTracking().FirstOrDefault(expression);
    }

    public void Dispose()
    {
        Db.Dispose();
        GC.SuppressFinalize(this);
    }
}