using Microsoft.EntityFrameworkCore;

namespace L2L.WeUI.Models
{
    public class L2lDbContext : DbContext
    {
        public L2lDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}