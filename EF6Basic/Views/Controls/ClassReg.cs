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
  public partial class ClassReg : UserControl
  {
    IEnumerable<School> _schools = default!;
    private bool _isLoaded = false;

    private void cmbSchool_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!_isLoaded) return;

      LoadClassesOnly();
    }

    private int GetSchoolId()
    {
      int.TryParse(cmbSchool.SelectedValue?.ToString(), out int schoolId);
      return schoolId;
    }

    private void AddSchoolComboItems()
    {
      cmbSchool.ValueMember = "Id";
      cmbSchool.DisplayMember = "Name";
      cmbSchool.DataSource = _schools;
    }
      
    public ClassReg()
    {
      InitializeComponent();
    }

    public Class SelectedValue { get => (Class)lbClass.SelectedValue; set => lbClass.SelectedValue = value; }       

    public Class GetInputData() => new Class { SchoolId = GetSchoolId(), Name = txtClass.Text.Trim() };

    internal void LoadClassesOnly()
    {
      var classes = _schools.FirstOrDefault(s => s.Id == GetSchoolId())?.Classes;

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
  }
}
