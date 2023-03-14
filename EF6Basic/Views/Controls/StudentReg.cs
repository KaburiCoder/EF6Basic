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
  public partial class StudentReg : UserControl
  {
    private IEnumerable<School> _schools = default!;
    private bool _isLoaded;

    private int GetSchoolId()
    {
      int.TryParse(cmbSchool.SelectedValue?.ToString(), out int schoolId);
      return schoolId;
    }

    private int GetClassId()
    {
      int.TryParse(cmbClass.SelectedValue?.ToString(), out int classId);
      return classId;
    }

    private void AddSchoolComboItems()
    {
      cmbSchool.ValueMember = "Id";
      cmbSchool.DisplayMember = "Name";
      cmbSchool.DataSource = _schools;
    }

    private void AddClassComboItems()
    {
      var classes = _schools.FirstOrDefault(s => s.Id == GetSchoolId())?.Classes;

      cmbClass.ValueMember = "Id";
      cmbClass.DisplayMember = "Name";
      cmbClass.DataSource = classes?.ToList();
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

      dgv.ReadOnly = true;
      dgv.AllowUserToAddRows = false;
      dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    public Student SelectedValue
    {
      get => (Student)dgv.CurrentRow?.Tag!; set
      {
        for (int i = 0; i < dgv.Rows.Count; i++)
        {
          var student = dgv.Rows[i].Tag as Student;
          if (student != null && student.Id == value.Id)
          {
            dgv.Rows[i].Selected = true;
          }
        }
      }
    }

    public Student GetInputData() => new Student
    {
      ClassId = GetClassId(),
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
      var students = _schools.FirstOrDefault(s => s.Id == GetSchoolId())?
                     .Classes?.FirstOrDefault(c => c.Id == GetClassId())?
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
  }
}
