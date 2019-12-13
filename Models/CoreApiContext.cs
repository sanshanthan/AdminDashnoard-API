using Microsoft.EntityFrameworkCore;

namespace CoreAPI.Models
{
    public class CoreApiContext: DbContext
    {
        public CoreApiContext (DbContextOptions<CoreApiContext> options) : base (options) { }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Server> Servers { get; set; }
    }
}