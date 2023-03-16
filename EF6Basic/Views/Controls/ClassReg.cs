using EF6Basic.Models;
using EF6Basic.Views.Controls;
using EF6Basic.Views.Utilities;
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
  public partial class ClassReg : UserControl, IReg
  {
    IEnumerable<School> _schools = default!;
    private bool _isLoaded = false;

    private void cmbSchool_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!_isLoaded) return;

      LoadClassesOnly();
    }

    private void AddSchoolComboItems()
    {
      cmbSchool.BindIdWithName(_schools);
    }

    public ClassReg()
    {
      InitializeComponent();
    }

    public object SelectedValue { get => lbClass.SelectedValue ?? 0; set => lbClass.SelectedValue = value; }

    public object GetInputData() => new Class { SchoolId = cmbSchool.GetIdOfSelectedValue(), Name = txtClass.Text.Trim() };

    internal void LoadClassesOnly()
    {
      var classes = _schools.FirstOrDefault(s => s.Id == cmbSchool.GetIdOfSelectedValue())?.Classes;

      lbClass.ValueMember = "Id";
      lbClass.DisplayMember = "Name";
      lbClass.DataSource = classes?.ToList();
    }

    public new void Load(IEnumerable<School> schools)
    {
      _schools = schools;

      _isLoaded = false;
      AddSchoolComboItems();
      LoadClassesOnly();
      _isLoaded = true;
    }

    public void Clear() => txtClass.Clear();
  }
}
