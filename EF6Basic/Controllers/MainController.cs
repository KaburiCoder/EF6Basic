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

    public MainController(ISchoolRepository schoolRepository)
    {
      this._schoolRepository = schoolRepository;
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
          break;
      }
    }
  }
}
