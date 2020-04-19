using Models.Profile.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Profile.Services.Interfaces
{
    public interface IUserService
    {
        IList<UserDto> GetUsers();

        UserDto GetUser(long id);

    }
}
