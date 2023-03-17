using EF6Basic.Controllers;
using EF6Basic.Database;
using EF6Basic.Repositories;
using EF6Basic.Views;
using Microsoft.Extensions.DependencyInjection;

namespace EF6Basic
{
  internal static class Program
  {   
    private static IServiceProvider ConfigureServices()
    {
      IServiceCollection services = new ServiceCollection();

      // 서비스 등록
      services.AddScoped<KabulDbContext>();

      services.AddTransient<ISchoolRepository, SchoolRepository>();
      services.AddTransient<IClassRepository, ClassRepository>();
      services.AddTransient<IStudentRepository, StudentRepository>();
      services.AddTransient<ISchoolClassStudentRepository, SchoolClassStudentRepository>();

      services.AddSingleton<MainController>();

      services.AddSingleton<IMain>(provider =>
      {
        IMain mainView = new MainView();
        var controller = provider.GetRequiredService<MainController>();
        controller.SetView(mainView);
        return mainView;
      });

      return services.BuildServiceProvider();
    }

    [STAThread]
    static void Main()
    {
      ApplicationConfiguration.Initialize();

      var services = ConfigureServices();
      var mainView = services.GetRequiredService<IMain>();

      Application.Run((Form)mainView);
    }
  }
}