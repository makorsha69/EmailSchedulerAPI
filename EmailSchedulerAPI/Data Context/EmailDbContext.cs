using EmailSchedulerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailSchedulerAPI.Data_Context
{
    public class EmailDbContext : DbContext
    {
        public EmailDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Url> Url { get; set; }
    }
}
