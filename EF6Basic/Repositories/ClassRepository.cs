using EF6Basic.Database;
using EF6Basic.Models;

namespace EF6Basic.Repositories
{
  public class ClassRepository : RepositoryBase<Class>, IClassRepository
  {
    public ClassRepository(KabulDbContext context) : base(context)
    {
    }
  }
}
