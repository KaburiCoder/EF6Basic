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

        var school = new School { Name = "¼­¿ï°í" };
        //context.Schools?.Add(school);
        context.Set<School>().Add(school);
        await context.SaveChangesAsync();

        var class1 = new Class { SchoolId = school.Id, Name = "1¹Ý" };
        var class2 = new Class { SchoolId = school.Id, Name = "2¹Ý" };
        //context.Classes?.Add(class1);
        //context.Classes?.Add(class2);
        context.Set<Class>().Add(class1);
        context.Set<Class>().Add(class2);
        await context.SaveChangesAsync();

        var student1 = new Student { ClassId = class1.Id, Name = "È«±æµ¿", Birthday = "19601201" };
        var student2 = new Student { ClassId = class1.Id, Name = "Àå³ª¶ó", Birthday = "19630125" };
        var student3 = new Student { ClassId = class2.Id, Name = "±èÃ¶¼ö", Birthday = "20001025" };
        //context.Students?.AddRange(new Student[] { student1, student2, student3 });
        context.Set<Student>().AddRange(new Student[] { student1, student2, student3 });
        await context.SaveChangesAsync();

        MessageBox.Show("ÀúÀåµÇ¾ú½À´Ï´Ù.");
      }
    }







    private void btnSelect_Click(object sender, EventArgs e)
    {
      using (var context = new KabulDbContext())
      {
        {
          // SELECT name, birthday FROM student WHERE birthday = '19940101' OR birthday = '19940202';         
          var query = from s in context.Students
                      where s.Name == "±èÃ¶¼ö" && (s.Birthday == "19940101" || s.Birthday == "19940202")
                      select new { s.Name, s.Birthday };

          var values = query.ToList();
        }

        {
          // SELECT name, birthday FROM student WHERE birthday IN ('19940101', '19940202', '19940303');
          var birthdays = new List<string> { "19940101", "19940202", "19940303" };
          var query = from s in context.Students
                      where birthdays.Contains(s.Birthday)
                      select new { s.Name, s.Birthday };

          var values = query.ToList();
        }

        {
          // SELECT name, birthday FROM student WHERE birthday BETWEEN '19940501' AND '19940601';
          var query = from s in context.Students
                      where string.Compare(s.Birthday, "19940501") >= 0
                      && string.Compare(s.Birthday, "19940601") <= 0
                      select new { s.Name, s.Birthday };

          var values = query.ToList();
        }

        {
          // SELECT name, birthday FROM student WHERE birthday <= '19940501';
          var query = from s in context.Students
                      where string.Compare(s.Birthday, "19940501") <= 0
                      select new { s.Name, s.Birthday };

          var values = query.ToList();
        }

        {
          // SELECT name FROM student WHERE name LIKE '%Ã¶%';
          var query = from s in context.Students
                      where s.Name.Contains("Ã¶")
                      select s.Name;

          var names = query.ToList();
        }

        {
          // SELECT name FROM student WHERE name LIKE '%¼ö';
          var query = from s in context.Students
                      where s.Name.EndsWith("¼ö")
                      select s.Name;

          var names = query.ToList();
        }

        {
          // SELECT * FROM student WHERE name LIKE '±è%';
          var query = from s in context.Students
                      where s.Name.StartsWith("±è")
                      select s;

          var students = query.ToList();
        }

        {
          // SELECT * FROM student WHERE name = '¹ÚÃ¶¼ö';
          var query = from s in context.Students
                      where s.Name == "¹ÚÃ¶¼ö"
                      select s;

          var students = query.ToList();
        }

        {
          // SELECT name FROM school
          var schoolsQuery = context.Schools.Select(s => s.Name); // ¸Þ¼­µå ±¸¹®
          var schools = schoolsQuery.ToList();

          // Äõ¸® Ç¥Çö½Ä
          var schoolsQuery2 = from s in context.Schools
                              select s.Name;
          var schools2 = schoolsQuery2.ToList();

          // SELECT name AS MyName FROM school
          var schoolsQuery3 = from s in context.Schools
                              select new { MyName = s.Name };
        }

        {
          // SELECT * FROM school
          var query = context.Schools.AsQueryable();
          var schools = query.ToList();
        }
      }
    }


















  }
}