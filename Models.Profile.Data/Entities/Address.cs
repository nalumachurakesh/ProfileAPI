using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Profile.Data.Entities
{
    public class Address
    {
        public Address()
        {
            UserAddresses = new List<UserAddress>();
        }
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public List<UserAddress> UserAddresses { get; set; }

    }
}
