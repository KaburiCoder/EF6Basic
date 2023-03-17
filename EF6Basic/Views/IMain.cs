using EF6Basic.Controllers;
using EF6Basic.Models;
using EF6Basic.Views.Enums;

namespace EF6Basic.Views
{
  public interface IMain
  {
    RegType RegType { get; set; }
    SearchType SearchType { get; }
    string SearchText { get; set; }
    int SelectedId { get; }
    void SetController(MainController controller);
    void LoadReg(IEnumerable<School> school);
    object GetInputData();
    void LoadStudentsOnly();
    void LoadClassesOnly();
    void Clear();
    void AddSearchComboBoxItems(Dictionary<SearchType, string> dict);
    void SearchDatasToGridView(List<SchoolClassStudent> results);
  }
}
