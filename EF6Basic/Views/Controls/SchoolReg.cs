using EF6Basic.Models;
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
  public partial class SchoolReg : UserControl
  {
    public SchoolReg()
    {
      InitializeComponent();
    }

    public School SelectedValue { get => (School)lbSchool.SelectedValue; set => lbSchool.SelectedValue = value; }

    public School GetInputData() => new School { Name = txtSchool.Text.Trim() };

    public new void Load(IEnumerable<School> schools)
    {
      lbSchool.ValueMember = "Id";
      lbSchool.DisplayMember = "Name";
      lbSchool.DataSource = schools;
    }
  }
}
