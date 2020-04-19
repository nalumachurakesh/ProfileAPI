using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Profile.Data.Entities
{
    public class UserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public User User { get; set; }
        public Address Address { get; set; }
    }
}
