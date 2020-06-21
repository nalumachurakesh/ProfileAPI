using Models.Profile.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Profile.Services.Interfaces
{
    public interface IUserService
    {
        IList<UserDTO> GetUsers();

        UserDTO GetUser(long id);

    }
}
