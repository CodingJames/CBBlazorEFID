using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CBBlazorEFID.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Customer> Customers { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}