using EF6Basic.Database;

namespace EF6Basic
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnConnection_Click(object sender, EventArgs e)
    {
      using (var context = new KabulDbContext())
      {
        lblStatus.Text = context.Database.Exists().ToString();
      }
    }

    private void btnCreateDatabase_Click(object sender, EventArgs e)
    {
      using (var context = new KabulDbContext())
      {
        context.Database.CreateIfNotExists();
      }
    }
  }
}