using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Entity;

namespace Corcentric.LunchAndLearnBlog.DomainModel
{
    public class Blog : Model
    {
        public String UserName { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
