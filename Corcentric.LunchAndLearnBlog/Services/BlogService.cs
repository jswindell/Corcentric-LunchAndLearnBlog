using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Corcentric.LunchAndLearnBlog.DomainModel;

namespace Corcentric.LunchAndLearnBlog.Services
{
    public sealed class BlogService : IBlogService
    {
        private DummyModel model = DummyModel.Instance;

        public Blog AddOrUpdate(Blog model) { throw new NotImplementedException(); }
        
        public Blog Get(int id) {
            var blogs = this.Get((Blog blog) => { return blog.ID == id; });
            return blogs != null && blogs.Any() ? blogs.First() : null;
        }
       
        public Blog[] Get(Func<Blog, bool> filter) {
            IEnumerable<Blog> blogs = this.model.GetBlogs();
            if (!blogs.Any())
            {
                return new Blog[] { };
            }

            blogs = blogs.Where(filter);
            if (!blogs.Any())
            {
                return new Blog[] { };
            }

            return blogs.ToArray();
        }
      
        public Blog Delete(int id) { throw new NotImplementedException(); }
        public Blog Delete(Blog model) { throw new NotImplementedException(); }
        public Blog[] Delete(Func<Blog, bool> filter) { throw new NotImplementedException(); }

        public Blog[] GetAll()
        {
            return this.model.GetBlogs().ToArray();
        }

        public Blog GetLast()
        {
            IList<Blog> blogs = this.GetAll();
            return blogs.Any() ? blogs.OrderByDescending(p => p.Date).First() : null;
        }
    }
}
