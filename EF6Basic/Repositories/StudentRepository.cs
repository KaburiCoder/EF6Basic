using EF6Basic.Database;
using EF6Basic.Models;

namespace EF6Basic.Repositories
{
  public class StudentRepository : RepositoryBase<Student>, IStudentRepository
  {
    public StudentRepository(KabulDbContext context) : base(context)
    {
    }
  }
}
