namespace Corcentric.LunchAndLearnBlog.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPosts3 : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "User_ID" });
            DropForeignKey("dbo.Posts", "User_ID", "dbo.Users");
            DropTable("dbo.Posts");
        }
    }
}
