﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Corcentric.LunchAndLearnBlog.DomainModel;

namespace Corcentric.LunchAndLearnBlog.Services
{
    public interface IUserService : ICrudService<User>
    {
        User[] GetAll();
    }
}
