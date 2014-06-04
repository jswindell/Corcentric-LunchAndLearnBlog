using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Corcentric.LunchAndLearnBlog.Web.Helpers
{
    public interface IServiceHelper
    {
        IBlogServiceHelper PostServiceHelper { get; }
        IUserServiceHelper UserServiceHelper { get; }
    }
}
