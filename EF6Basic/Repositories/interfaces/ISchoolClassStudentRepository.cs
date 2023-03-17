using EF6Basic.Models;

namespace EF6Basic.Repositories
{
  public interface ISchoolClassStudentRepository : IRepositoryBase<SchoolClassStudent>
  {
    Task<List<SchoolClassStudent>> GetAllByBirthdayNameAsync(string searchText);
    public Task<List<SchoolClassStudent>> GetAllBySchoolNameAsync(string schoolName);
    Task<List<SchoolClassStudent>> GetAllByStudentNameAsync(string searchText);
  }
}