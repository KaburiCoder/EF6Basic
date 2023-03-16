using EF6Basic.Models;
using EF6Basic.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF6Basic.Views
{
  public partial class SchoolReg : UserControl, IReg
  {
    public SchoolReg()
    {
      InitializeComponent();
    }

    public object SelectedValue { get => lbSchool.SelectedValue ?? 0; set => lbSchool.SelectedValue = value; }

    public void Clear() => txtSchool.Clear();

    public object GetInputData() => new School { Name = txtSchool.Text.Trim() };

    public new void Load(IEnumerable<School> schools)
    {
      lbSchool.ValueMember = "Id";
      lbSchool.DisplayMember = "Name";
      lbSchool.DataSource = schools;
    }
  }
}
