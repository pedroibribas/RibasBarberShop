using Microsoft.EntityFrameworkCore;
using RibasBarberShop.Domain.Entities;

namespace RibasBarberShop.Infrastructure.Configuration
{
    public class SchedulingContext : DbContext
    {
        public DbSet<ScheduledDate> ScheduledDates { get; set; }

        private string DbPath { get; }

        public SchedulingContext()
        {
            string host = "localhost:5432";
            string username = "postgres";
            string password = "pedro";
            string database = "RibasBarberShop";
            DbPath = @$"Host={host};Username={username};Password={password};Database={database}";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(DbPath);
    }
}
