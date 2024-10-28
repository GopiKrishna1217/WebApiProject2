using Microsoft.EntityFrameworkCore;

namespace WebApiProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UsersDetails { get; set; }
    }
}
