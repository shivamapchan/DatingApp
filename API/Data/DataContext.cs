using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class NewBaseType
    {
    }

    public class DataContext : DbContext // Derived from DbContext class
    {
        public DataContext(DbContextOptions options) : base(options) // Generating constructor
        {
        }
        public DbSet<AppUser> Users { get; set; } // Users table
    }
}