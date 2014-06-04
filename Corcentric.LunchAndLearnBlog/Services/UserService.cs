using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Corcentric.LunchAndLearnBlog.DomainModel;

namespace Corcentric.LunchAndLearnBlog.Services
{
    public sealed class UserService : IUserService
    {
        private DummyModel model = DummyModel.Instance;

        public User AddOrUpdate(User model) { throw new NotImplementedException(); }
        
        public User Get(int id) { 
            var users = this.Get((User user) => { return user.ID == id; });
            return users != null && users.Any() ? users.First() : null;
        }
        
        public User[] Get(Func<User, bool> filter) {            
            IEnumerable<User> users = this.model.GetUsers();
            if (!users.Any())
            {
                return new User[] { };
            }

            users = users.Where(filter);
            if (!users.Any())
            {
                return new User[] { };
            }

            return users.ToArray();
        }
        
        public User Delete(int id) { throw new NotImplementedException(); }
        public User Delete(User model) { throw new NotImplementedException(); }
        public User[] Delete(Func<User, bool> filter) { throw new NotImplementedException(); }

        public User[] GetAll()
        {
            return this.model.GetUsers().ToArray();
        }
    }
}
