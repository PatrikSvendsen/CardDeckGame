using System.Linq.Expressions;

namespace Contracts;

/// <summary>
/// Generiskt interface för CRUD-operationer mot databasen
/// </summary>
/// <typeparam name="T">Generisk class.</typeparam>
public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
    bool trackChanges);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
