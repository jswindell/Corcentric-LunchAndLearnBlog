using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Corcentric.LunchAndLearnBlog.DomainModel;
using Corcentric.LunchAndLearnBlog.Services;
using Corcentric.LunchAndLearnBlog.Web.Models;
using Corcentric.LunchAndLearnBlog.Web.Translators;

namespace Corcentric.LunchAndLearnBlog.Web.Helpers
{
    public sealed class BlogServiceHelper : IBlogServiceHelper
    {
        private readonly IBlogService blogService;

        public BlogServiceHelper()
        {
            this.blogService = new BlogService();
        }

        public BlogServiceHelper(IBlogService blogService)
        {
            // TODO: Guard null.
            this.blogService = blogService;
        }

        public Post AddOrUpdate(Post model)
        {
            var translator = new PostTranslator();
            var post = this.blogService.AddOrUpdate(translator.ToDto(model));

            return translator.ToViewModel(post);
        }

        public Post Get(int id)
        {
            var translator = new PostTranslator();
            var post = this.blogService.Get(id);

            return translator.ToViewModel(post);
        }

        public Post Delete(int id)
        {
            var translator = new PostTranslator();
            var post = this.blogService.Delete(id);

            return translator.ToViewModel(post);
        }

        public Post Delete(Post model)
        {
            var translator = new PostTranslator();
            var post = this.blogService.Delete(translator.ToDto(model));

            return translator.ToViewModel(post);
        }

        public Post[] GetAll()
        {
            var translator = new PostTranslator();
            var blog = this.blogService.GetAll();

            var blogs = new List<Post>();
            blog.ToList().ForEach(p => blogs.Add(translator.ToViewModel(p)));

            return blogs.ToArray();
        }

        public Post GetLast()
        {
            var blog = this.blogService.GetLast();
            var translator = new PostTranslator();

            return translator.ToViewModel(blog);
        }
    }
}