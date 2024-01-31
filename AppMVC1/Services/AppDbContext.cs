using AppMVC1.Models;
using Microsoft.EntityFrameworkCore;

namespace AppMVC1.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) :base(option)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
