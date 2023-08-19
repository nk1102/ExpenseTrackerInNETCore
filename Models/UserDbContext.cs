using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerInNETCore.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
    }
}
