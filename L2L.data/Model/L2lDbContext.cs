using Microsoft.EntityFrameworkCore;

namespace L2L.WeUI.Models
{
    public class L2lDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
    }
}