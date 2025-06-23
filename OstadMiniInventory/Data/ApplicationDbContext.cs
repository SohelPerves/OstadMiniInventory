using Microsoft.EntityFrameworkCore;
using OstadMiniInventory.Models;

namespace OstadMiniInventory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
