namespace Corcentric.LunchAndLearnBlog.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPosts4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "User_ID", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "User_ID" });
            AlterColumn("dbo.Posts", "User_ID", c => c.Int(nullable: false));
            DropTable("dbo.Users");
        }
        
        public override void Down()
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
            
            AlterColumn("dbo.Posts", "User_ID", c => c.Int());
            CreateIndex("dbo.Posts", "User_ID");
            AddForeignKey("dbo.Posts", "User_ID", "dbo.Users", "ID");
        }
    }
}
