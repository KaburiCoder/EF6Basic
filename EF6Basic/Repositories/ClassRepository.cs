using EF6Basic.Database;
using EF6Basic.Models;
using System.Data.Entity;

namespace EF6Basic.Repositories
{
  public class ClassRepository : RepositoryBase<Class>, IClassRepository
  {
    public ClassRepository(KabulDbContext context) : base(context)
    {
    }

    public async Task<bool> Exists(int schoolId, string name)
    {
      return await DbSet.Where(x => x.SchoolId == schoolId && x.Name == name).AnyAsync();
    }
  }
}
