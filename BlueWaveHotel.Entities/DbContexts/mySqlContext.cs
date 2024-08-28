using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlueWaveHotel.Entities.DbContexts
{
    public class mySqlContext : DbContext
    {
        public DbSet<BedType> bedTypes { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Extra> extras { get; set; }
        public DbSet<Floor> floors { get; set; }
        public DbSet<Package> packages { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Profession> professions { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<SalaryType> salaryTypes { get; set; }
        public DbSet<Shift> shifts { get; set; }
        public DbSet<TimeTracking> timeTrackings { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=BlueWaveDB;Uid=root;Pwd=asd123";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 38));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
