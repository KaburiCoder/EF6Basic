using EF6Basic.Database;
using EF6Basic.Models;

namespace EF6Basic.Repositories
{
  public class SchoolRepository : RepositoryBase<School>, ISchoolRepository
  {
    public SchoolRepository(KabulDbContext context) : base(context)
    {
    }
  }
}
