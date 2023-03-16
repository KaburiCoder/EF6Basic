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
  public partial class StudentReg : UserControl, IReg
  {
    private IEnumerable<School> _schools = default!;
    private bool _isLoaded;

    private void AddSchoolComboItems()
    {
      cmbSchool.BindIdWithName(_schools);
    }

    private void AddClassComboItems()
    {
      var classes = _schools.FirstOrDefault(s => s.Id == cmbSchool.GetIdOfSelectedValue())?.Classes;
      cmbClass.BindIdWithName(classes?.ToList());
    }

    private void cmbSchool_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!_isLoaded) return;
      AddClassComboItems();
      LoadStudentsOnly();
    }

    private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!_isLoaded) return;

      LoadStudentsOnly();
    }

    public StudentReg()
    {
      InitializeComponent();

      dgv.SetReadOnlySettings();      
    }

    public object SelectedValue
    {
      get => dgv.CurrentRow?.Tag is Student st ? st.Id : 0;
      set
      {
        for (int i = 0; i < dgv.Rows.Count; i++)
        {
          var student = dgv.Rows[i].Tag as Student;
          if (student != null && value is Student st && student.Id == st.Id)
          {
            dgv.Rows[i].Selected = true;
          }
        }
      }
    }

    public object GetInputData() => new Student
    {
      ClassId = cmbClass.GetIdOfSelectedValue(),
      Name = txtName.Text.Trim(),
      Birthday = dtpBirth.Value.ToString("yyyyMMdd"),
    };

    public new void Load(IEnumerable<School> schools)
    {
      _schools = schools;

      _isLoaded = false;
      AddSchoolComboItems();
      AddClassComboItems();
      LoadStudentsOnly();
      _isLoaded = true;
    }

    internal void LoadStudentsOnly()
    {
      var students = _schools.FirstOrDefault(s => s.Id == cmbSchool.GetIdOfSelectedValue())?
                     .Classes?.FirstOrDefault(c => c.Id == cmbClass.GetIdOfSelectedValue())?
                     .Students?.ToList();

      dgv.RowCount = 0;
      if (students != null)
      {
        dgv.RowCount = students.Count;
        int row = 0;
        foreach (var student in students)
        {
          dgv.Rows[row].Tag = student;
          dgv["이름", row].Value = student.Name;
          dgv["생일", row++].Value = student.Birthday;
        }
      }
    }

    public void Clear()
    {
      txtName.Clear();
      dtpBirth.Value = DateTime.Now;
    }
  }
}
