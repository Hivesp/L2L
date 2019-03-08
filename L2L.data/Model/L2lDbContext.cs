using Microsoft.EntityFrameworkCore;
using JetBrains.Annotations;
namespace L2L.Data.Model
{
    public class L2lDbContext : DbContext
    {
                public L2lDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        
    }
}