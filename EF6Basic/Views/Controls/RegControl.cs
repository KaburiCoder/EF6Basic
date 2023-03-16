using EF6Basic.Models;
using EF6Basic.Views.Controls;
using System.ComponentModel;

namespace EF6Basic.Views
{
  public partial class RegControl : UserControl
  {
    public event EventHandler? SelectedTabIndexChanged;

    private void tab_SelectedIndexChanged(object sender, EventArgs e)
    {
      SelectedTabIndexChanged?.Invoke(sender, e);
    }

    private IReg CurrentReg => (IReg)tab.SelectedTab.Controls[0];

    public RegControl()
    {
      InitializeComponent();
    }

    [DefaultValue(RegType.School)]
    public RegType RegType
    {
      get => tab.SelectedTab.Name switch
      {
        nameof(tpgSchool) => RegType.School,
        nameof(tpgClass) => RegType.Class,
        _ => RegType.Student,
      };
      set
      {
        tab.SelectedIndex = (int)value;
      }
    }

    public int SelectedId => (int)CurrentReg.SelectedValue;
    public new void Load(IEnumerable<School> schools) => CurrentReg.Load(schools);

    public void Clear() => CurrentReg.Clear();

    public object GetInputData() => CurrentReg.GetInputData();    
    internal void LoadClassesOnly() => classReg.LoadClassesOnly();
    internal void LoadStudentsOnly() => studentReg.LoadStudentsOnly();
  }
}
