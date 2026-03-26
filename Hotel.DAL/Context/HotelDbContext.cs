using Hotel.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Hotel.DAL
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().HasKey(g => g.PhoneNumber);

            modelBuilder.Entity<Reservation>().HasOne(r => r.Room).WithOne().HasForeignKey<Reservation>(r => r.RoomNumber);

            modelBuilder.Entity<Reservation>().HasOne(r => r.Guest).WithMany(g => g.Reservations).HasForeignKey(r => r.GuestPhoneNumber);

            modelBuilder.Entity<Reservation>().HasIndex(r => r.RoomNumber).IsUnique();

        }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
    }
}
