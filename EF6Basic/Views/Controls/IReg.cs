using EF6Basic.Models;

namespace EF6Basic.Views.Controls
{
  public interface IReg
  {
    object SelectedValue { get; set; }
    object GetInputData();
    void Load(IEnumerable<School> schools);
    void Clear();
  }
}
