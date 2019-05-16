namespace CourseRegistrationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        DepartmentCode = c.String(nullable: false, maxLength: 5),
                        CourseNumber = c.Int(nullable: false),
                        CourseTitle = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => new { t.DepartmentCode, t.CourseNumber })
                .ForeignKey("dbo.Department", t => t.DepartmentCode, cascadeDelete: true)
                .Index(t => t.DepartmentCode);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentCode = c.String(nullable: false, maxLength: 5),
                        DepartmentName = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.DepartmentCode);
            
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        InstructorName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.InstructorId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.InstructorCourse",
                c => new
                    {
                        InstructorId = c.Int(nullable: false),
                        DepartmentCode = c.String(nullable: false, maxLength: 5),
                        CourseNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InstructorId, t.DepartmentCode, t.CourseNumber })
                .ForeignKey("dbo.Instructor", t => t.InstructorId, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => new { t.DepartmentCode, t.CourseNumber }, cascadeDelete: true)
                .Index(t => t.InstructorId)
                .Index(t => new { t.DepartmentCode, t.CourseNumber });
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        DepartmentCode = c.String(nullable: false, maxLength: 5),
                        CourseNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.DepartmentCode, t.CourseNumber })
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => new { t.DepartmentCode, t.CourseNumber }, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => new { t.DepartmentCode, t.CourseNumber });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourse", new[] { "DepartmentCode", "CourseNumber" }, "dbo.Course");
            DropForeignKey("dbo.StudentCourse", "StudentId", "dbo.Student");
            DropForeignKey("dbo.InstructorCourse", new[] { "DepartmentCode", "CourseNumber" }, "dbo.Course");
            DropForeignKey("dbo.InstructorCourse", "InstructorId", "dbo.Instructor");
            DropForeignKey("dbo.Course", "DepartmentCode", "dbo.Department");
            DropIndex("dbo.StudentCourse", new[] { "DepartmentCode", "CourseNumber" });
            DropIndex("dbo.StudentCourse", new[] { "StudentId" });
            DropIndex("dbo.InstructorCourse", new[] { "DepartmentCode", "CourseNumber" });
            DropIndex("dbo.InstructorCourse", new[] { "InstructorId" });
            DropIndex("dbo.Course", new[] { "DepartmentCode" });
            DropTable("dbo.StudentCourse");
            DropTable("dbo.InstructorCourse");
            DropTable("dbo.Student");
            DropTable("dbo.Instructor");
            DropTable("dbo.Department");
            DropTable("dbo.Course");
        }
    }
}
