using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;

namespace Corcentric.LunchAndLearnBlog.Web.Models
{
    public class LogonModel
    {
        private string m_userName;
        private string m_password;


        public string userName
        {
            get
            {
                return m_userName;
            }
            set
            {
                m_userName = value;
            }
        }

        public string password
        {
            get
            {
                return m_password;
            }
            set
            {
                m_password = value;
            }
        }

        
    }
}