using System.Data.Entity;

namespace EF6Basic.Repositories
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
  {
    protected readonly DbContext Context;
    protected readonly DbSet<T> DbSet;

    public RepositoryBase(DbContext context)
    {
      this.Context = context;
      this.DbSet = context.Set<T>();
    }

    public async Task<bool> DeleteAsync(T entity)
    {
      DbSet.Remove(entity);
      int count = await Context.SaveChangesAsync();

      return count > 0;
    }

    public async Task<bool> DeleteByIdAsync(int id)
    {
      T entity = await DbSet.FindAsync(id);

      return await DeleteAsync(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
      return await DbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
      return await DbSet.FindAsync(id);
    }

    //AsQueryable 메서드는 메모리 내에서 데이터에 대한 쿼리 가능한 개체를 만들기 때문에 비동기 작업이 필요하지 않습니다.
    public IQueryable<T> GetQueryable()
    {
      return DbSet.AsQueryable();
    }

    public async Task<bool> InsertAsync(T entity)
    {
      DbSet.Add(entity);
      int count = await Context.SaveChangesAsync();

      return count > 0;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
      Context.Entry(entity).State = EntityState.Modified;
      int count = await Context.SaveChangesAsync();

      return count > 0;
    }
  }
}
