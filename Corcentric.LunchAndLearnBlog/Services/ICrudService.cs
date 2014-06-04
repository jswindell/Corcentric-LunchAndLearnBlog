using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Corcentric.LunchAndLearnBlog.DomainModel;

namespace Corcentric.LunchAndLearnBlog.Services
{
    public interface ICrudService<TModel> where TModel : Model
    {
        TModel AddOrUpdate(TModel model);
        TModel Get(int id);
        TModel[] Get(Func<TModel, bool> filter);        
        TModel Delete(int id);
        TModel Delete(TModel model);
        TModel[] Delete(Func<TModel, bool> filter);
    }
}
