using EF6Basic.Controllers.Validations;
using EF6Basic.Models;
using EF6Basic.Repositories;
using EF6Basic.Views;
using EF6Basic.Views.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    private readonly ISchoolClassStudentRepository _schoolClassStudentRepository;
    private IMain _view = default!;

    #region Save Methods

    // Save School 
    private async Task SaveSchoolReg(School school)
    {
      if (!MainSaveValidation.ValidSchool(school)) return;
      if (await _schoolRepository.ExistByName(school.Name)) return;
      if (await _schoolRepository.InsertAsync(school))
      {
        await LoadReg();
      }
    }

    // Save Class
    private async Task SaveClassReg(Class cls)
    {
      if (!MainSaveValidation.ValidClass(cls)) return;
      if (await _classRepository.Exists(cls.SchoolId, cls.Name)) return;
      if (await _classRepository.InsertAsync(cls))
      {
        _view.LoadClassesOnly();
      }
    }

    // Save Student
    private async Task SaveStudentReg(Student student)
    {
      if (!MainSaveValidation.ValidStudent(student)) return;
      if (await _studentRepository.InsertAsync(student))
      {
        _view.LoadStudentsOnly();
      }
    }
    #endregion

    private void AddSearchComboBoxItems()
    {
      var dict = new Dictionary<SearchType, string>();
      dict.Add(SearchType.StudentName, "학생이름");
      dict.Add(SearchType.SchoolName, "학교");
      dict.Add(SearchType.Birthday, "생년월일");

      _view.AddSearchComboBoxItems(dict);
    }

    public MainController(ISchoolRepository schoolRepository,
      IClassRepository classRepository,
      IStudentRepository studentRepository,
      ISchoolClassStudentRepository schoolClassStudentRepository)
    {
      this._schoolRepository = schoolRepository;
      this._classRepository = classRepository;
      this._studentRepository = studentRepository;
      this._schoolClassStudentRepository = schoolClassStudentRepository;
    }

    public async Task LoadReg()
    {
      var schools = await _schoolRepository.GetAllAsync();
      _view.LoadReg(schools);
    }

    internal void SetView(IMain mainView)
    {
      _view = mainView;
      _view.SetController(this);
    }

    internal async void FormLoaded()
    {
      AddSearchComboBoxItems();
      await LoadReg();
    }

    internal async Task OnSave()
    {
      var inputData = _view.GetInputData();

      if (inputData is School school)
      {
        await SaveSchoolReg(school);
      }
      else if (inputData is Class cls)
      {
        await SaveClassReg(cls);
      }
      else if (inputData is Student student)
      {
        await SaveStudentReg(student);
      }
      _view.Clear();
    }

    internal async Task OnDelete()
    {
      int selectedId = _view.SelectedId;
      if (selectedId == 0) return;

      switch (_view.RegType)
      {
        case RegType.School:
          if (await _schoolRepository.DeleteByIdAsync(selectedId))
          {
            await LoadReg();
          }
          break;
        case RegType.Class:
          if (await _classRepository.DeleteByIdAsync(selectedId))
          {
            _view.LoadClassesOnly();
          }
          break;
        default:
          if (await _studentRepository.DeleteByIdAsync(selectedId))
          {
            _view.LoadStudentsOnly();
          }
          break;
      }
    }

    internal async void OnSearched()
    {
      List<SchoolClassStudent> results = _view.SearchType switch
      {
        SearchType.SchoolName => await _schoolClassStudentRepository.GetAllBySchoolNameAsync(_view.SearchText),
        SearchType.Birthday => await _schoolClassStudentRepository.GetAllByBirthdayNameAsync(_view.SearchText),
        _ => await _schoolClassStudentRepository.GetAllByStudentNameAsync(_view.SearchText),
      };
      _view.SearchDatasToGridView(results);
    }
  }
}
