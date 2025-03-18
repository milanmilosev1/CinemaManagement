using CinemaManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaManagement.Infrastructure.DataContext
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options) { }

        public CinemaDbContext() { }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Screening> Screenings{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Console.WriteLine("Model created");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CinemaDB;Username=postgres;Password=milan4321");
        }
    }
}
