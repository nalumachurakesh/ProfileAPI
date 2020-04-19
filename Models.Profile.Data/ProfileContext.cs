using Microsoft.EntityFrameworkCore;
using Models.Profile.Data.Entities;

namespace Models.Profile.Data
{
    public class ProfileContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
    }
}
