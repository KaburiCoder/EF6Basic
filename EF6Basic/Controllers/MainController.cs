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
    private readonly ISchoolRepository _schoolRepository;
    private IMain _view;

    public MainController(ISchoolRepository schoolRepository)
    {
      this._schoolRepository = schoolRepository;

      var school = _schoolRepository.GetQueryable().ToList();
    }

    internal void SetView(IMain mainView)
    {
      _view = mainView;
    }
  }
}
