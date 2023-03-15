using EF6Basic.Models;

namespace EF6Basic.Controllers.Validations
{
  public class MainSaveValidation
  {
    public static bool ValidSchool(School school)
    {
      if (school == null) return false;
      if (string.IsNullOrWhiteSpace(school.Name)) return false;

      return true;
    }

    public static bool ValidClass(Class cls)
    {
      if (cls == null) return false;
      if (string.IsNullOrWhiteSpace(cls.Name)) return false;
      if (cls.SchoolId == 0) return false;

      return true;
    }

    public static bool ValidStudent(Student student)
    {
      if (student == null) return false;
      if (string.IsNullOrWhiteSpace(student.Name) || student.Birthday == default) return false;
      if (student.ClassId == 0) return false;

      return true;
    }
  }
}
