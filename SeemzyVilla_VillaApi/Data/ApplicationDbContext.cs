using Microsoft.EntityFrameworkCore;
using SeemzyVilla_VillaApi.Models;

namespace SeemzyVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Villa>()
                .HasData(
                    new Villa
                    {
                        Id = 1,
                        Name = "WidWasFad Villa",
                        Amenity = "",
                        CreatedAt = DateTime.Now,
                        Sqrft = 345,
                        Details = "Very Solid charle",
                        Rate = 230.2,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1701086292958-f753f3bb5d27?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                    },
                    new Villa
                    {
                        Id = 2,
                        Name = "Vandox Villa",
                        Amenity = "",
                        CreatedAt = DateTime.Now,
                        Sqrft = 345,
                        Details = "4 Star Villa",
                        Rate = 2670.2,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1701086292958-f753f3bb5d27?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                    },
                    new Villa
                    {
                        Id = 3,
                        Name = "GyeNyame Villa",
                        Amenity = "",
                        CreatedAt = DateTime.Now,
                        Sqrft = 345,
                        Details = "2 Star Villa",
                        Rate = 310.2,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1701086292958-f753f3bb5d27?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                    }
                );
        }
    }
}
