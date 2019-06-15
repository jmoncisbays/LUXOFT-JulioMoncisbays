using Microsoft.EntityFrameworkCore;

namespace Luxoft_JMoncisbays_WebAPI.Models
{
    public class LuxoftJMoncisbaysDbContext : DbContext
    {
        public LuxoftJMoncisbaysDbContext(DbContextOptions<LuxoftJMoncisbaysDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
