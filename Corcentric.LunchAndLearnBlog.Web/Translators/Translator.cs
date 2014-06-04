using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Corcentric.LunchAndLearnBlog.Web.Models;
using Corcentric.LunchAndLearnBlog.DomainModel;

namespace Corcentric.LunchAndLearnBlog.Web.Translators
{
    public abstract class Translator<TDto, TViewModel>
        where TDto : Corcentric.LunchAndLearnBlog.DomainModel.Model, new()
        where TViewModel : Corcentric.LunchAndLearnBlog.Web.Models.IModel, new()
    {
        public virtual TDto ToDto(TViewModel viewModel)
        {
            return new TDto()
            {
                ID = viewModel.ID,
                Error = viewModel.Error
            };
        }

        public virtual TViewModel ToViewModel(TDto dto)
        {
            return new TViewModel()
            {
                ID = dto.ID,
                Error = dto.Error
            };
        }
    }
}