using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Corcentric.LunchAndLearnBlog.Web.Models;
using Corcentric.LunchAndLearnBlog.Web.Helpers;

namespace Corcentric.LunchAndLearnBlog.Web.Controllers
{
    public class PostController : Controller
    {

        private readonly IBlogServiceHelper blogServiceHelper;

        public PostController()
        {
            this.blogServiceHelper = new BlogServiceHelper();
        }

        public PostController(IBlogServiceHelper blogServiceHelper)
        {
            this.blogServiceHelper = blogServiceHelper;
        }

        public ActionResult Posts()
        {
            return View(blogServiceHelper.GetAll());
        }

    }
}
