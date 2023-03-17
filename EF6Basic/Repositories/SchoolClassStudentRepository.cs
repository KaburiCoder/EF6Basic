using EF6Basic.Database;
using EF6Basic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Basic.Repositories
{
  public class SchoolClassStudentRepository : RepositoryBase<SchoolClassStudent>, ISchoolClassStudentRepository
  {
    public SchoolClassStudentRepository(KabulDbContext context) : base(context)
    {
    }

    public IQueryable<SchoolClassStudent> GetLeftJoinedQueryable()
    {
      var query = from school in Context.Set<School>()
                  join cls in Context.Set<Class>() on school.Id equals cls.SchoolId into clsGroup
                  from cls in clsGroup.DefaultIfEmpty()
                  join student in Context.Set<Student>() on cls.Id equals student.ClassId into studentGroup
                  from student in studentGroup.DefaultIfEmpty()
                  select new SchoolClassStudent
                  {
                    SchoolName = school.Name,
                    ClassName = cls == null ? "" : cls.Name,
                    StudentName = student == null ? "" : student.Name,
                    Birthday = student == null ? "" : student.Birthday,
                  };

      return query;
    }

    public async Task<List<SchoolClassStudent>> GetAllBySchoolNameAsync(string schoolName)
    {
      var query = GetLeftJoinedQueryable();
      return await query
        .Where(s => s.SchoolName.IndexOf(schoolName) > -1)
        .OrderBy(s => s.ClassName)
        .ThenBy(s => s.StudentName)
        .ToListAsync();
    }

    public async Task<List<SchoolClassStudent>> GetAllByBirthdayNameAsync(string birthday)
    {
      var query = GetLeftJoinedQueryable();
      return await query
        .Where(s => s.Birthday == birthday)
        .OrderBy(s => s.Birthday)
        .ToListAsync();
    }

    public async Task<List<SchoolClassStudent>> GetAllByStudentNameAsync(string studentName)
    {
      var query = GetLeftJoinedQueryable();
      return await query
        .Where(s => s.StudentName.IndexOf(studentName) > -1)
        .OrderBy(s => s.StudentName)
        .ThenBy(s => s.ClassName)
        .ToListAsync();
    }
  }
}
