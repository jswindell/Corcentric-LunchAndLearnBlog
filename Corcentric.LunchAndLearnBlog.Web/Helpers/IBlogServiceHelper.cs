using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Corcentric.LunchAndLearnBlog.Web.Models;

namespace Corcentric.LunchAndLearnBlog.Web.Helpers
{
    public interface IBlogServiceHelper
    {
        Post AddOrUpdate(Post model);
        Post Get(int id);        
        Post Delete(int id);
        Post Delete(Post model);
        Post[] GetAll();
        Post GetLast();
    }
}
