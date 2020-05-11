namespace ApiSpark.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        LogId = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 75),
                        Password = c.String(nullable: false, maxLength: 55),
                    })
                .PrimaryKey(t => t.LogId);
            
            DropTable("dbo.Academy");
            DropTable("dbo.Courses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Slug = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        Length = c.Long(nullable: false),
                        TotalSteps = c.Long(nullable: false),
                        Updated = c.String(),
                        Steps = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Academy",
                c => new
                    {
                        AcademyId = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 55),
                        Avatar = c.String(nullable: false),
                        Status = c.String(),
                        Mood = c.String(),
                        Unread = c.String(),
                    })
                .PrimaryKey(t => t.AcademyId);
            
           // DropTable("dbo.Login");
        }
    }
}
