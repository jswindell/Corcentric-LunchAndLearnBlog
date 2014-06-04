using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Corcentric.LunchAndLearnBlog.Web.Models
{

    public partial class PostPartialModel
    {
        public string UserName { get; set; }
        public int ID { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }

    }
    public partial class PostPartialModel
    {
        public List<PostPartialModel> partialModels { get; set; }

    }




}