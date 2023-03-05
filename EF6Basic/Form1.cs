using EF6Basic.Database;
using EF6Basic.Models;

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

    private async void btnSave_Click(object sender, EventArgs e)
    {
      using (var context = new KabulDbContext())
      {
        // CRUD => DbSet
        // Create

        var school = new School { Name = "서울고" };
        context.Schools?.Add(school);
        await context.SaveChangesAsync();

        var class1 = new Class { SchoolId = school.Id, Name = "1반" };
        var class2 = new Class { SchoolId = school.Id, Name = "2반" };
        context.Classes?.Add(class1);
        context.Classes?.Add(class2);
        await context.SaveChangesAsync();

        var student1 = new Student { ClassId = class1.Id, Name = "홍길동", Birthday = "19601201" };
        var student2 = new Student { ClassId = class1.Id, Name = "장나라", Birthday = "19630125" };
        var student3 = new Student { ClassId = class2.Id, Name = "김철수", Birthday = "20001025" };
        context.Students?.AddRange(new Student[] { student1, student2, student3 });
        await context.SaveChangesAsync();

        MessageBox.Show("저장되었습니다.");
      }
    }
  }
}