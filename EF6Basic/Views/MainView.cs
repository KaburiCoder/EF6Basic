using EF6Basic.Controllers;
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
  public partial class MainView : Form, IMain
  {
    private MainController _cont = default!;
     
    private void MainView_Load(object? sender, EventArgs e)
    {
      _cont.FormLoaded();
    }

    private async void regControl_SelectedTabIndexChanged(object sender, EventArgs e)
    {
      await _cont.LoadReg();
    }

    public MainView()
    {
      InitializeComponent();
      Load += MainView_Load;
    }

    public RegType RegType { get => regControl.RegType; set => regControl.RegType = value; }

    public void SetController(MainController controller)
    {
      _cont = controller;
    }

    public void LoadSchoolReg(IEnumerable<School> schools)
    {
      regControl.LoadSchoolReg(schools);
    }      

    public void LoadClassReg(IEnumerable<School> schools)
    {
      regControl.LoadClassReg(schools);
    }
  }
}
