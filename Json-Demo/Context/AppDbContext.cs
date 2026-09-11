using Json_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Json_Demo.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
    }
}
