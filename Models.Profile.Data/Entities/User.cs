using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Profile.Data.Entities
{
    public class User
    {
        public User()
        {
            UserAddresses = new List<UserAddress>();
        }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRegistered { get; set; }
        public List<UserAddress> UserAddresses { get; set; }
    }
}
