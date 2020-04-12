using Data.Profile.Repositories.Interfaces;
using Models.Profile.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Profile.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
                
        }

        public IList<User> GetUsers()
        {
           return new List<User> 
            {
                new User
                {
                    Id= 123,
                    FirstName="test1",
                    LastName="test1",
                    IsRegistered=false,
                },
                new User
                {
                    Id= 123,
                    FirstName="test2",
                    LastName="test2",
                    IsRegistered=false,
                }
            };
        }

        public User GetUser(long id)
        {
            return new User
            {
                Id = 123,
                FirstName = "test1",
                LastName = "test1",
                IsRegistered = false,
            };
        }
    }
}
