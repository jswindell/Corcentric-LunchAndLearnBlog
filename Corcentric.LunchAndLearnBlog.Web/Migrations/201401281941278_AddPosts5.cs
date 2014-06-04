namespace Corcentric.LunchAndLearnBlog.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPosts5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "UserName", c => c.String());
            DropColumn("dbo.Posts", "User_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "User_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Posts", "UserName");
        }
    }
}
