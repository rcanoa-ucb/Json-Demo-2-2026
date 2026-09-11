using Microsoft.EntityFrameworkCore;

namespace Json_Demo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
    }
}
