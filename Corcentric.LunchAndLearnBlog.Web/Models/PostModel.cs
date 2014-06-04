using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Corcentric.LunchAndLearnBlog.Web.Models
{
    public class PostModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }

    public class PostDBContext : DbContext
    {
        public DbSet<PostModel> Posts { get; set; }
    }

}