using EF6Basic.Database;
using EF6Basic.Models;

namespace EF6Basic
{
  public partial class LegacyForm1 : Form
  {
    public LegacyForm1()
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
          //SELECT c.id, c.name, 'ºó µ¥ÀÌÅÍ' birthday FROM class c
          //UNION ALL
          //SELECT s.id, s.name, s.birthday FROM student s          
          var classQuery = from c in context.Classes
                           select new { Id = c.Id, Name = c.Name, Birthday = "ºó µ¥ÀÌÅÍ" };

          var studentQuery = from s in context.Students
                             select new { s.Id, s.Name, s.Birthday };

          var unionQuery = classQuery.Union(studentQuery);

          var values = unionQuery.ToList();
        }

        {
          //SELECT c.name, s.name, s.birthday FROM class c
          //LEFT JOIN student s
          //ON c.id = s.class_id
          //WHERE s.birthday > '19940202'
          var query = from c in context.Classes
                      join s in context.Students
                        on c.Id equals s.ClassId
                        into joinedData
                      from jd in joinedData.DefaultIfEmpty()
                      where string.Compare(jd == null ? "" : jd.Birthday, "19940202") > 0
                      select new
                      {
                        ClassName = c.Name,
                        StudentName = jd == null ? "" : jd.Name,
                        StudentBirthday = jd == null ? "" : jd.Birthday,
                      };

          var values = query.ToList();
        }




        {
          //SELECT c.name, s.name, s.birthday FROM class c
          //INNER JOIN student s
          //ON c.id = s.class_id
          //WHERE s.birthday > '19940202'        

          var query = from s in context.Students
                      where string.Compare(s.Birthday, "19940202") > 0
                      select new
                      {
                        ClassName = s.Class == null ? "" : s.Class.Name,
                        StudentName = s.Name,
                        StudentBirthday = s.Birthday,
                      };

          //var query = from c in context.Classes
          //            join s in context.Students
          //            on c.Id equals s.ClassId
          //            where string.Compare(s.Birthday, "19940202") > 0
          //            select new
          //            {
          //              ClassName = c.Name,
          //              StudentName = s.Name,
          //              StudentBirthday = s.Birthday,
          //            };

          var values = query.ToList();
        }

        {
          // SELECT name, birthday FROM student
          // WHERE birthday > '19940202'
          // GROUP BY class_id
          // ORDER BY birthday DESC, name DESC
          var query = from s in context.Students
                      where string.Compare(s.Birthday, "19940202") > 0
                      orderby s.Birthday descending, s.Name descending
                      group s by s.ClassId into g
                      select new
                      {
                        ClassId = g.Key,
                        Count = g.Count(),
                        Students = g.Select(s => new { s.Id, s.Name })
                      };

          var values = query.ToList();
        }

        {
          // SELECT name, birthday FROM student
          // WHERE birthday > '19940202'
          // GROUP BY class_id
          // ORDER BY birthday DESC, name DESC
          var query = from s in context.Students
                      where string.Compare(s.Birthday, "19940202") > 0
                      orderby s.Birthday descending, s.Name descending
                      group s by s.ClassId into g
                      select new
                      {
                        ClassId = g.Key,
                        Count = g.Count(),
                        Students = g.Select(s => new { s.Id, s.Name })
                      };

          var values = query.ToList();
        }

        {
          /* ÁÖÀÇ */
          // Skip ¸Þ¼­µå´Â orderby(Á¤·Ä)ÀÌ µÇÁö ¾ÊÀ¸¸é ¿À·ù°¡ ¹ß»ýÇÑ´Ù.

          // SELECT name, birthday FROM student
          // WHERE birthday > '19940202'
          // ORDER BY birthday DESC, name DESC
          // LIMIT 5, 10;         
          var query = (from s in context.Students
                       where string.Compare(s.Birthday, "19940202") > 0
                       orderby s.Birthday descending, s.Name descending
                       select new { s.Name, s.Birthday })
                      .Skip(5)
                      .Take(10);

          var values = query.ToList();
        }

        {
          // SELECT name, birthday FROM student
          // WHERE birthday > '19940202'
          // ORDER BY birthday DESC, name DESC
          // LIMIT 5, 10;         
          var query = (from s in context.Students
                       where string.Compare(s.Birthday, "19940202") > 0
                       orderby s.Birthday descending, s.Name descending
                       select new { s.Name, s.Birthday })
                      .Skip(5)
                      .Take(10);

          var values = query.ToList();
        }

        {
          // SELECT name, birthday FROM student
          // WHERE birthday > '19940202'
          // ORDER BY birthday DESC, name DESC;         
          var query = from s in context.Students
                      where string.Compare(s.Birthday, "19940202") > 0
                      orderby s.Birthday descending, s.Name descending
                      select new { s.Name, s.Birthday };

          var values = query.ToList();
        }

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

    // Update
    private void btnUpdate_Click(object sender, EventArgs e)
    {
     
      using (var context = new KabulDbContext())
      {
        //student - id : 1 name: È«±æµ¿ birthday: 19940101
        Student findedStudent = context.Students.Find(1);

        // Update
        findedStudent.Birthday = "20000101";
        context.Entry(findedStudent).State = System.Data.Entity.EntityState.Modified;
        context.SaveChanges();

        Student student = context.Students.Find(1);

        MessageBox.Show($"{student.Id} / {student.Name} / {student.Birthday}");
      }
    }

    // Delete
    private void btnDelete_Click(object sender, EventArgs e)
    {
      using (var context = new KabulDbContext())
      {
        Student student = context.Students.Find(2);

        context.Students.Remove(student);
        context.SaveChanges();
      }
    }   
  }
}