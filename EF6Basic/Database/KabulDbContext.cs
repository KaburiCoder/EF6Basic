using EF6Basic.Models;
using EF6Basic.Properties;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace EF6Basic.Database
{
  [DbConfigurationType(typeof(MySqlEFConfiguration))]
  public class KabulDbContext : DbContext
  {
    public KabulDbContext() : base(Settings.Default.KABUL_CONNECTIONSTRING)
    {
    }

    // DbSet
    public DbSet<School>? Schools { get; set; }
    public DbSet<Class>? Classes { get; set; }
    public DbSet<Student>? Students { get; set; }
  }
}
