using Microsoft.EntityFrameworkCore;

namespace InstantFeedback.Models
{
    public class IssuesContext : DbContext
    {
        public IssuesContext(DbContextOptions options) : base(options) { }

        public DbSet<Issue> Issues { get; set; }
        public DbSet<User> Users { get; set; }
    }
}