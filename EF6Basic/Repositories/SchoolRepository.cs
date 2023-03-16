using EF6Basic.Database;
using EF6Basic.Models;
using System.Data.Entity;

namespace EF6Basic.Repositories
{
  public class SchoolRepository : RepositoryBase<School>, ISchoolRepository
  {
    public SchoolRepository(KabulDbContext context) : base(context)
    {
    }

    public async Task<bool> ExistByName(string name)
    {
      return await DbSet.Where(x => x.Name == name).AnyAsync();
    }   
  }
}
