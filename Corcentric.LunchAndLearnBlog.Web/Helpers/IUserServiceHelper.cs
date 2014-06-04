using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Corcentric.LunchAndLearnBlog.Web.Models;

namespace Corcentric.LunchAndLearnBlog.Web.Helpers
{
    public interface IUserServiceHelper
    {
        User AddOrUpdate(User model);
        User Get(int id);        
        User Delete(int id);
        User Delete(User model);        
        User[] GetAll();
    }
}
