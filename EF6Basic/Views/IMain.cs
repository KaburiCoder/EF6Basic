using EF6Basic.Controllers;
using EF6Basic.Models;

namespace EF6Basic.Views
{
  public interface IMain
  {
    RegType RegType { get; set; }
    int SelectedId { get; }
    void SetController(MainController controller);
    void LoadReg(IEnumerable<School> school);
    object GetInputData();
    void LoadStudentsOnly();
    void LoadClassesOnly();
    void Clear();
  }
}
