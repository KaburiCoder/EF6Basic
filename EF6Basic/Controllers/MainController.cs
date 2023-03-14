using EF6Basic.Models;
using EF6Basic.Repositories;
using EF6Basic.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Basic.Controllers
{
  public class MainController
  {
    private readonly ISchoolRepository _schoolRepository = default!;
    private readonly IClassRepository _classRepository;
    private readonly IStudentRepository _studentRepository;
    private IMain _view = default!;

    private async Task LoadSchoolReg()
    {
      var schools = await _schoolRepository.GetAllAsync();
      _view.LoadSchoolReg(schools);
    }

    private async Task LoadClassReg()
    {
      var schools = await _schoolRepository.GetAllAsync();
      _view.LoadClassReg(schools);
    }

    private async Task LoadStudentReg()
    {
      var schools = await _schoolRepository.GetAllAsync();
      _view.LoadStudentReg(schools);
    }

    #region Save Methods
    // Save School
    private async Task<bool> ValidSchoolSave(School school)
    {
      if (school == null) return false;
      if (string.IsNullOrWhiteSpace(school.Name)) return false;
      if (await _schoolRepository.ExistByName(school.Name)) return false;

      return true;
    }

    private async Task SaveSchoolReg()
    {
      School school = _view.GetSchoolInputData();
      if (!await ValidSchoolSave(school)) return;

      if (await _schoolRepository.InsertAsync(school))
      {
        await LoadReg();
      }
    }

    // Save Class
    private async Task<bool> ValidClassSave(Class cls)
    {
      if (cls == null) return false;
      if (string.IsNullOrWhiteSpace(cls.Name)) return false;
      if (cls.SchoolId == 0) return false;
      if (await _classRepository.Exists(cls.SchoolId, cls.Name)) return false;

      return true;
    }

    private async Task SaveClassReg()
    {
      Class cls = _view.GetClassInputData();
      if (!await ValidClassSave(cls)) return;

      if (await _classRepository.InsertAsync(cls))
      {
        _view.LoadClassesOnly();        
      }
    }

    // Save Student
    private bool ValidStudentSave(Student student)
    {
      if (student == null) return false;
      if (string.IsNullOrWhiteSpace(student.Name) || student.Birthday == default) return false;
      if (student.ClassId == 0) return false;

      return true;
    }

    private async Task SaveStudentReg()
    {
      Student student = _view.GetStudentInputData();
      if (!ValidStudentSave(student)) return;

      if (await _studentRepository.InsertAsync(student))
      {
        _view.LoadStudentsOnly();
      }
    }
    #endregion

    public MainController(ISchoolRepository schoolRepository, IClassRepository classRepository, IStudentRepository studentRepository)
    {
      this._schoolRepository = schoolRepository;
      this._classRepository = classRepository;
      this._studentRepository = studentRepository;
    }

    internal void SetView(IMain mainView)
    {
      _view = mainView;
      _view.SetController(this);
    }

    internal async void FormLoaded()
    {
      await LoadReg();
    }

    internal async Task LoadReg()
    {
      switch (_view.RegType)
      {
        case RegType.School:
          await LoadSchoolReg();
          break;
        case RegType.Class:
          await LoadClassReg();
          break;
        default:
          await LoadStudentReg();
          break;
      }
    }

    internal async Task OnSave()
    {
      switch (_view.RegType)
      {
        case RegType.School:
          await SaveSchoolReg();
          break;
        case RegType.Class:
          await SaveClassReg();
          break;
        default:
          await SaveStudentReg();
          break;
      }
    }

    internal async Task OnDelete()
    {
      throw new NotImplementedException();
    }
  }
}
