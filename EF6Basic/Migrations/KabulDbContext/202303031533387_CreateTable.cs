namespace EF6Basic.Migrations.KabulDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.class",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        school_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.school", t => t.school_id, cascadeDelete: true)
                .Index(t => t.school_id);
            
            CreateTable(
                "dbo.school",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.student",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        age = c.Int(nullable: false),
                        class_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.class", t => t.class_id, cascadeDelete: true)
                .Index(t => t.class_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.student", "class_id", "dbo.class");
            DropForeignKey("dbo.class", "school_id", "dbo.school");
            DropIndex("dbo.student", new[] { "class_id" });
            DropIndex("dbo.class", new[] { "school_id" });
            DropTable("dbo.student");
            DropTable("dbo.school");
            DropTable("dbo.class");
        }
    }
}
