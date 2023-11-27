using Microsoft.EntityFrameworkCore;
using SeemzyVilla_VillaApi.Models;

namespace SeemzyVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Villa> Villas { get; set; }
    }
}
