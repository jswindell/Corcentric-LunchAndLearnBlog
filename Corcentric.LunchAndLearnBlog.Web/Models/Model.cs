using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Corcentric.LunchAndLearnBlog.Web.Models
{
    public abstract class Model : IModel
    {
        private string error;

        public Model()
        {
        }

        public int ID { get; set; }

        public string Error
        {
            get
            {
                return this.error;
            }
            set
            {
                this.error = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
            }
        }

        public bool HasError
        {
            get { return !string.IsNullOrWhiteSpace(this.error); }
        }
    }
}