using EF6Basic.Controllers;
using EF6Basic.Models;

namespace EF6Basic.Views
{
  public interface IMain
  {
    RegType RegType { get; set; }
    void SetController(MainController controller);
    void LoadSchoolReg(IEnumerable<School> school);
    void LoadClassReg(IEnumerable<School> schools);
  }
}
