using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Corcentric.LunchAndLearnBlog.DomainModel
{
    internal sealed class DummyModel
    {
        private static readonly DummyModel instance = new DummyModel();

        private List<User> users;
        private List<Blog> blogs;

        protected DummyModel()
        {
            this.InitUsers();
            this.InitBlogs();
        }

        private void InitUsers()
        {
            const int totalUsers = 100;
            var date = DateTime.UtcNow;
            var users = new List<User>();
            for (var i = 0; i < totalUsers; i++)
            {
                var id = i + 1;
                var user = new User() { ID = id, UserName = "gangelo", AccountExpDate = date.AddMonths(12), Active = true, FirstName = string.Format("FirstName{0}", i), LastName = string.Format("LasttName{0}", i), Password = "password", PasswordExpDate = date.AddMonths(12) };
                users.Add(user);
            }

            this.users = users;
        }

        private void InitBlogs()
        {
            const int totalBlogs = 100;
            var date = DateTime.UtcNow;
            var blogs = new List<Blog>();
            for (var i = 0; i < totalBlogs; i++)
            {
                var id = i + 1;
                var blogDate = date.AddDays(-(totalBlogs - i));
                var blog = new Blog() { ID = id, Body = string.Format("This is blog post #{0}", id), Date = blogDate, Subject = string.Format("blog post #{0}", id), UserName = "gangelo" };
                blogs.Add(blog);
            }

            this.blogs = blogs;
        }

        public static DummyModel Instance
        {
            get { return DummyModel.instance; }
        }

        public List<User> GetUsers()
        {
            return this.users;
        }

        public List<Blog> GetBlogs()
        {
            return this.blogs;
        }
    }
}
