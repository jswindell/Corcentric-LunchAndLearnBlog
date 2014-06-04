using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Corcentric.LunchAndLearnBlog.Web.Models;
using Corcentric.LunchAndLearnBlog.Web.Helpers;

namespace Corcentric.LunchAndLearnBlog.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserServiceHelper userServiceHelper;

        public UsersController()
        {
            this.userServiceHelper = new UserServiceHelper();
        }

        public UsersController(IUserServiceHelper userServiceHelper)
        {
            this.userServiceHelper = userServiceHelper;
        }

        //
        // GET: /Users/

        public ActionResult Index()
        {
            var users = this.userServiceHelper.GetAll();
            return View(users);
        }

        //
        // GET: /Users/Details/5

        public ActionResult Details(int id)
        {
            var user = this.userServiceHelper.Get(id);
            return View(user);
        }

        //
        // GET: /Users/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Users/Create

        [HttpPost]
        public ActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                model = this.userServiceHelper.AddOrUpdate(model);
            }
            return View(model);
        }

        //
        // GET: /Users/Edit/5

        public ActionResult Edit(int id)
        {
            var model = this.userServiceHelper.Get(id);            
            return View(model);
        }

        //
        // POST: /Users/Edit/5

        [HttpPost]
        public ActionResult Edit(User model)
        {
            if (ModelState.IsValid)
            {
                model = this.userServiceHelper.AddOrUpdate(model);
            }
            return View(model);
        }

        //
        // GET: /Users/Delete/5

        public ActionResult Delete(int id)
        {
            var model = this.userServiceHelper.Delete(id);
            return View(model);
        }
    }
}