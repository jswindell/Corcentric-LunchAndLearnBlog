using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ViewModel = Corcentric.LunchAndLearnBlog.Web.Models;
using DomainModel = Corcentric.LunchAndLearnBlog.DomainModel;

namespace Corcentric.LunchAndLearnBlog.Web.Translators
{
    public sealed class UserTranslator : Translator<DomainModel.User, ViewModel.User>
    {
        public override DomainModel.User ToDto(ViewModel.User viewModel)
        {
            if (viewModel == null)
            {
                return new DomainModel.User();
            }

            var dto = base.ToDto(viewModel);

            dto.ID = viewModel.ID;
            dto.LastName = viewModel.LastName;
            dto.Password = viewModel.Password;
            dto.PasswordExpDate = viewModel.PasswordExpDate;
            dto.UserName = viewModel.UserName;

            return dto;
        }

        public override ViewModel.User ToViewModel(DomainModel.User dto)
        {
            if (dto == null)
            {
                return new ViewModel.User();
            }

            var viewModel = base.ToViewModel(dto);

            viewModel.ID = dto.ID;
            viewModel.LastName = dto.LastName;
            viewModel.Password = dto.Password;
            viewModel.PasswordExpDate = dto.PasswordExpDate;
            viewModel.UserName = dto.UserName;

            return viewModel;
        }
    }
}