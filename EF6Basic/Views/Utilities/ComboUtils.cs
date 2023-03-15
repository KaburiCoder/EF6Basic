using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Basic.Views.Utilities
{
  public static class ComboUtils
  {
    public static void BindIdWithName(this ComboBox comboBox, object? dataSource)
    {
      comboBox.ValueMember = "Id";
      comboBox.DisplayMember = "Name";
      comboBox.DataSource = dataSource;
    }

    public static int GetIdOfSelectedValue(this ComboBox comboBox)
    {
      int.TryParse(comboBox.SelectedValue?.ToString(), out int value);
      return value;
    }
  }
}
