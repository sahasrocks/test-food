using Microsoft.EntityFrameworkCore;

namespace Project2.Models
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) :base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
