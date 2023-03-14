using EF6Basic.Models;

namespace EF6Basic.Repositories
{
  public interface IClassRepository : IRepositoryBase<Class>
  {
    Task<bool> Exists(int schoolId, string name);
  }
}
