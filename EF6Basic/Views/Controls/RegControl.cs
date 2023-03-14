﻿using EF6Basic.Models;
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

    public void LoadSchoolReg(IEnumerable<School> schools)
    {
      schoolReg.Load(schools);
    }

    public void LoadClassReg(IEnumerable<School> schools)
    {
      classReg.Load(schools);
    }

    public void LoadStudentReg(IEnumerable<School> schools)
    {
      studentReg.Load(schools);
    }

    public School GetSchoolInputData() => schoolReg.GetInputData();
    public Class GetClassInputData() => classReg.GetInputData();
    public Student GetStudentInputData() => studentReg.GetInputData();
    internal void LoadClassesOnly() => classReg.LoadClassesOnly();
    internal void LoadStudentsOnly() => studentReg.LoadStudentsOnly();
  }
}
