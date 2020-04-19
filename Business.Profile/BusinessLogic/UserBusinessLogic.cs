using Business.Profile.BusinessLogic.Interfaces;
using Data.Profile.Repositories.Interfaces;
using Models.Profile.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Profile.BusinessLogic
{
    public class UserBusinessLogic : IUserBusinessLogic
    {

        private readonly IUserRepository _userRepository;

        public UserBusinessLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        User IUserBusinessLogic.GetUser(long id)
        {
            return _userRepository.GetUser(id);
        }

        IList<User> IUserBusinessLogic.GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
