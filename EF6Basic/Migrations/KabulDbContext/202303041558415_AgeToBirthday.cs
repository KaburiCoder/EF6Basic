namespace EF6Basic.Migrations.KabulDbContext
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class AgeToBirthday : DbMigration
  {
    public override void Up()
    {
      //AddColumn("dbo.student", "birthday", c => c.String(nullable: false, maxLength: 8, storeType: "nvarchar"));
      Sql("ALTER TABLE student ADD COLUMN birthday VARCHAR(8) NOT NULL AFTER name");
      DropColumn("dbo.student", "age");
    }

    public override void Down()
    {
      AddColumn("dbo.student", "age", c => c.Int(nullable: false));
      DropColumn("dbo.student", "birthday");
    }
  }
}
