using EF6Basic.Properties;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Basic.Database
{
  [DbConfigurationType(typeof(MySqlEFConfiguration))]
  public class KabulDbContext : DbContext
  {
    public KabulDbContext() : base("name=KABUL_CONNECTIONSTRING")
    {
    }
  }
}
