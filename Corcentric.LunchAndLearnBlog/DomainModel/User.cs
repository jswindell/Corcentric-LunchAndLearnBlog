using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Entity;

namespace Corcentric.LunchAndLearnBlog.DomainModel
{
    public class User : Model
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime AccountExpDate { get; set; }
        public DateTime PasswordExpDate { get; set; }
        public bool Active { get; set; }
    }
}
