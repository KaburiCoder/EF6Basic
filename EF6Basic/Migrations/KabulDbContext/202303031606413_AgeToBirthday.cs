namespace EF6Basic.Migrations.KabulDbContext
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class AgeToBirthday : DbMigration
  {
    public override void Up()
    {
      //AddColumn("student", "birthday", c => c.String(nullable: false, maxLength: 8));
      Sql("ALTER TABLE student ADD COLUMN birthday VARCHAR(8) NOT NULL AFTER name");
      DropColumn("student", "age");
    }

    public override void Down()
    {
      AddColumn("student", "age", c => c.Int(nullable: false));
      DropColumn("student", "birthday");
    }
  }
}
