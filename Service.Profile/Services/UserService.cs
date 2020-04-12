using Business.Profile.BusinessLogic.Interfaces;
using Models.Profile.Dto.Dtos;
using Service.Profile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Profile.Services
{
    public class UserService : IUserService
    {
        private readonly IUserBusinessLogic _userBusinessLogic;

        public UserService(IUserBusinessLogic userBusinessLogic)
        {
            _userBusinessLogic = userBusinessLogic;
        }

        UserDto IUserService.GetUser(long id)
        {
            var user = _userBusinessLogic.GetUser(id);

            return new UserDto
            {
                FirstName = user.FirstName,
                Id = user.Id,
                IsRegistered = user.IsRegistered,
                LastName = user.LastName
            };
        }

        IList<UserDto> IUserService.GetUsers()
        {
            var users = _userBusinessLogic.GetUsers();

            return users.Select(user => new UserDto
            {
                FirstName = user.FirstName,
                Id = user.Id,
                IsRegistered = user.IsRegistered,
                LastName = user.LastName
            }).ToList();
        }
    }
}
