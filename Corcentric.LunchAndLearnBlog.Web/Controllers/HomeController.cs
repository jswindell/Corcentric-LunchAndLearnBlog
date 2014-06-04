using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Corcentric.LunchAndLearnBlog.Web.Models;
using System.Security.Cryptography;
using Corcentric.LunchAndLearnBlog.DomainModel;
using Corcentric.LunchAndLearnBlog.Services;

using Corcentric.LunchAndLearnBlog.Web.Helpers;

namespace Corcentric.LunchAndLearnBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogServiceHelper blogServiceHelper;

        public HomeController()
        {
            this.blogServiceHelper = new BlogServiceHelper();
        }

        public HomeController(IBlogServiceHelper blogServiceHelper)
        {
            this.blogServiceHelper = blogServiceHelper;
        }

        public ActionResult Index()
        {
            var blog = this.blogServiceHelper.GetLast();

            return View(new HomeIndexViewModel()
            {
                Title = blog.Subject,
                DailyMessage = blog.Body
            });
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult LogonPage(LogonModel model)
        {
            if (model.userName != null && model.password != null)
            {
            }
            ViewBag.Key = Corcentric.LunchAndLearnBlog.Services.EncryptionServices.publicKey;
            return View("LogonPage");
        }
    }
}
