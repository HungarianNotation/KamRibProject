using Microsoft.EntityFrameworkCore;
using KamRib.Models;

namespace KamRib.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
