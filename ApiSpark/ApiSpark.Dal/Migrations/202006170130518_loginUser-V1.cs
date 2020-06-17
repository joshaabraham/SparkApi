namespace ApiSpark.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loginUserV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        userID = c.Guid(nullable: false),
                        Avatar = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.userID);
            
            AddColumn("dbo.Login", "UserRole", c => c.String());
            CreateIndex("dbo.Login", "LogId");
            AddForeignKey("dbo.Login", "LogId", "dbo.User", "userID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Login", "LogId", "dbo.User");
            DropIndex("dbo.Login", new[] { "LogId" });
            DropColumn("dbo.Login", "UserRole");
            DropTable("dbo.User");
        }
    }
}
