using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DomainModel = Corcentric.LunchAndLearnBlog.DomainModel;
using Corcentric.LunchAndLearnBlog.Services;
using Corcentric.LunchAndLearnBlog.Web.Models;
using Corcentric.LunchAndLearnBlog.Web.Translators;

namespace Corcentric.LunchAndLearnBlog.Web.Helpers
{
    public sealed class UserServiceHelper : IUserServiceHelper
    {
        private readonly IUserService userService;

        public UserServiceHelper()
        {
            this.userService = new UserService();
        }

        public UserServiceHelper(IUserService userService)
        {
            // TODO: Guard null.
            this.userService = userService;
        }

        public User AddOrUpdate(User model)
        {
            var translator = new UserTranslator();
            var user = this.userService.AddOrUpdate(translator.ToDto(model));

            return translator.ToViewModel(user);
        }

        public User Get(int id)
        {
            var translator = new UserTranslator();
            var userDto = this.userService.Get(id);

            return translator.ToViewModel(userDto);
        }

        public User Delete(int id)
        {
            var translator = new UserTranslator();
            var user = this.userService.Delete(id);

            return translator.ToViewModel(user);
        }

        public User Delete(User model)
        {
            var translator = new UserTranslator();
            var user = this.userService.Delete(translator.ToDto(model));

            return translator.ToViewModel(user);
        }

        public User[] GetAll()
        {
            var translator = new UserTranslator();
            var usersDto = this.userService.GetAll();

            var users = new List<User>();
            usersDto.ToList().ForEach(p => users.Add(translator.ToViewModel(p)));

            return users.ToArray();
        }
    }
}