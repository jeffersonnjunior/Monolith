using System.Linq.Expressions;

namespace Infrastructure.Interfaces;
public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    IQueryable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> expression, params string[] includes);
    TEntity GetElementByExpression(Expression<Func<TEntity, bool>> expression, params string[] includes);
}
