using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Profile.Dto.Dtos
{
    public class UserDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRegistered { get; set; }
        public string FullName => $"{FirstName}, {LastName}";
    }
}
