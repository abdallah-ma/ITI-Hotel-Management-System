using Hotel.DAL.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Hotel.DAL
{
    public class HotelIdentityDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["HotelIdentity"].ConnectionString);
        }
        
        public DbSet<User> Users { get; set; }

        public DbSet<Kitchen> Kitchens { get; set; }

    }
}
