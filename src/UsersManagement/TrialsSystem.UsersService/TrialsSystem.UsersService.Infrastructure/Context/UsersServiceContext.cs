using Microsoft.EntityFrameworkCore;
using TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate;
using TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate;

namespace TrialsSystem.UsersService.Infrastructure.Context
{
    public class UsersServiceContext : DbContext
    {
        public UsersServiceContext(DbContextOptions<UsersServiceContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>() /*.Navigation(e => e.City).AutoInclude()*/;
            modelBuilder.Entity<User>() /*.Navigation(e => e.Gender).AutoInclude()*/;


            modelBuilder.Entity<Gender>();

            modelBuilder.Entity<City>();
        }
    }
}