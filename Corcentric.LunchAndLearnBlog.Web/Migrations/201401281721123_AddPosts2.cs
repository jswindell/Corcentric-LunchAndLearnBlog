namespace Corcentric.LunchAndLearnBlog.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPosts2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "User_ID", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "User_ID" });
            DropTable("dbo.Posts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PostDate = c.DateTime(nullable: false),
                        Subject = c.String(),
                        Body = c.String(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Posts", "User_ID");
            AddForeignKey("dbo.Posts", "User_ID", "dbo.Users", "ID");
        }
    }
}
