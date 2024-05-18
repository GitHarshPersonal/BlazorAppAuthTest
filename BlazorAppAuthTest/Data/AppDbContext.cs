using BlazorAppAuthTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppAuthTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
