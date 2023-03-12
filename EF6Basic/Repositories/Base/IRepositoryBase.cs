using System.Diagnostics;

namespace EF6Basic.Repositories
{
  public interface IRepositoryBase<T> where T : class
  {
    IQueryable<T> GetQueryable();
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<bool> InsertAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(T entity);
    Task<bool> DeleteByIdAsync(int id);
  }
}
