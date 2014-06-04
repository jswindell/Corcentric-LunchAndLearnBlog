using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Corcentric.LunchAndLearnBlog.Web.Models;

namespace Corcentric.LunchAndLearnBlog.Web.Helpers
{
    public sealed class ServiceHelper : IServiceHelper
    {
        private readonly IBlogServiceHelper blogServiceHelper;
        private readonly IUserServiceHelper userServiceHelper;

        public ServiceHelper()
        {
            this.blogServiceHelper = new BlogServiceHelper();
            this.userServiceHelper = new UserServiceHelper();
        }

        public ServiceHelper(IBlogServiceHelper blogServiceHelper, IUserServiceHelper userServiceHelper)
        {
            // TODO: Guard null.
            this.blogServiceHelper = blogServiceHelper;
            this.userServiceHelper = userServiceHelper;
        }

        public IBlogServiceHelper PostServiceHelper
        {
            get { 
                return this.blogServiceHelper; 
            }
        }

        public IUserServiceHelper UserServiceHelper
        {
            get
            {
                return this.userServiceHelper;
            }
        }
    }
}