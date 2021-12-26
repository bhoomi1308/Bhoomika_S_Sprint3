using System.Data.Entity;

namespace BhoomikaSadashiva_Sprint2.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<TaskModel> TaskModel { get; set; }
    }
}
