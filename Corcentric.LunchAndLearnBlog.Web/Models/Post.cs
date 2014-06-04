using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Corcentric.LunchAndLearnBlog.Web.Models
{
    public class Post : Model 
    {
        public Post() { 
        }

        public String UserName { get; set; }
        public DateTime PostDate { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}