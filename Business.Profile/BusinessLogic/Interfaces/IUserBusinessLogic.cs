using Models.Profile.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Profile.BusinessLogic.Interfaces
{
    public interface IUserBusinessLogic
    {
        IList<User> GetUsers();
        User GetUser(long id);
    }
}
