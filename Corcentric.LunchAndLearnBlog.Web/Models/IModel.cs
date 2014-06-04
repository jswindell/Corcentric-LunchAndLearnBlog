using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Corcentric.LunchAndLearnBlog.Web.Models
{
    public interface IModel
    {
        int ID { get; set; }
        string Error { get; set; }
        bool HasError { get; }
    }
}
