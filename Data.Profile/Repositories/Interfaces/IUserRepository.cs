using Models.Profile.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Profile.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IList<User> GetUsers();
        User GetUser(long id);
    }
}
