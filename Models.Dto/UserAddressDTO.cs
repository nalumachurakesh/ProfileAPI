using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Profile.Dto
{
    public class UserAddressDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public UserDTO User { get; set; }
        public AddressDTO Address { get; set; }
    }
}
