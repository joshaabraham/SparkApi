namespace ApiSpark.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
            DropTable("dbo.Academy");
        }
    }
}
