namespace JopWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTabel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StdudentName = c.String(nullable: false),
                        StudentNamber = c.String(nullable: false),
                        StudentPhone = c.String(nullable: false),
                        StudentEmail = c.String(nullable: false),
                        StudentAddress = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropTable("dbo.Students");
        }
    }
}
