using Microsoft.EntityFrameworkCore;
using Models.Profile.Data.Entities;

namespace Models.Profile.Data
{
    public class ProfileContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = .; Database =  ProfileData; Trusted_Connection = True";
            optionsBuilder.UseSqlServer(connectionString);
        }  

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
    }
}
