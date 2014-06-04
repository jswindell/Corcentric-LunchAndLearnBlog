using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Entity;

namespace Corcentric.LunchAndLearnBlog.DomainModel
{
    public abstract class Model
    {
        public int ID { get; set; }
        public string Error { get; set; }
        public bool HasError { get { return !string.IsNullOrWhiteSpace(this.Error); } }
    }
}
