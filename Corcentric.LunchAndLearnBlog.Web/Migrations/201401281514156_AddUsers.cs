namespace Corcentric.LunchAndLearnBlog.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        password = c.String(),
                        AccountExpDate = c.DateTime(nullable: false),
                        PasswordExpDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.PostModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PostModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Body = c.String(),
                        Subject = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Users");
        }
    }
}
