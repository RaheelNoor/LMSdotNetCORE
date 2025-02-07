using Microsoft.EntityFrameworkCore;
using LMSPro.Model;

namespace LMSPro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Author> Authors { get; set; }
    }
}
