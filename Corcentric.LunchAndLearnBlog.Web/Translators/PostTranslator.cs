using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Corcentric.LunchAndLearnBlog.Web.Models;
using Corcentric.LunchAndLearnBlog.DomainModel;

namespace Corcentric.LunchAndLearnBlog.Web.Translators
{
    public sealed class PostTranslator : Translator<Blog, Post>
    {
        public override Blog ToDto(Post viewModel)
        {
            if (viewModel == null)
            {
                return new Blog();
            }

            var dto = base.ToDto(viewModel);

            dto.Body = viewModel.Body;
            dto.Date = viewModel.PostDate;
            dto.Subject = viewModel.Subject;
            dto.UserName = viewModel.UserName;

            return dto;
        }

        public override Post ToViewModel(Blog dto)
        {
            if (dto == null)
            {
                return new Post();
            }

            var viewModel = base.ToViewModel(dto);

            viewModel.Body = dto.Body;
            viewModel.PostDate = dto.Date;
            viewModel.Subject = dto.Subject;
            viewModel.UserName = dto.UserName;

            return viewModel;
        }
    }
}