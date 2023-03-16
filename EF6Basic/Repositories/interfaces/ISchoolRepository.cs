using EF6Basic.Models;

namespace EF6Basic.Repositories
{
  public interface ISchoolRepository : IRepositoryBase<School>
  {
    public Task<bool> ExistByName(string name);
  }
}
